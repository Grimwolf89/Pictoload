using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Domain.Entities;
using Pictoload.Data;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace WebUI.Pages.Userdashboard
{
    public class AddPhotoToAlbumModel : PageModel
    {
        private readonly Pictoload.Data.ApplicationDbContext _context;
        readonly IMediator _mediator;
        private readonly SignInManager<IdentityUser> _signInManager;


        public string PhotoId { get; set; }
        [BindProperty]
        public int AlbumId { get; set; }

        [BindProperty]
        public string Album { get; set; }

        [BindProperty]
        public string userId { get; set; }

        [BindProperty]
        public IList<Album> UserAlbums { get; set; }

        [BindProperty]
        public PhotoAlbum PhotoAlbum { get; set; }

        public AddPhotoToAlbumModel(Pictoload.Data.ApplicationDbContext context, IMediator mediator, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _mediator = mediator;
            _signInManager = signInManager;
        }

        public async Task OnGetAsync(int? id)
        {
            
            
            PhotoId = id.ToString();
            userId = _signInManager.UserManager.GetUserId(User);
            var UserAlbumsx = await _mediator.Send(new Application.Album.Queries.GetUserAlbumsList.GetUserAlbumListQuery() { UserId = userId });
            UserAlbums = UserAlbumsx.ToList();
            


        }

        
        public async Task<IActionResult> OnPostAsync()
        {
            userId = _signInManager.UserManager.GetUserId(User);

            var UserAlbumsx = await _mediator.Send(new Application.Album.Queries.GetUserAlbumsList.GetUserAlbumListQuery() { UserId = userId });

            Album = Request.Form["selectedAlbum"];

            var albumToAdd = await _mediator.Send(new Application.Album.Queries.GetAlbumByName.GetAlbumByNameQuery() { UserId = userId, AlbumName = Album });

            PhotoId = Request.Form["photoId"];

            int pId = int.Parse(PhotoId);

            await _mediator.Send(new Application.Album.Commands.AddPhotoToAlbum.AddPhotoToAlbumCommand() { PhotoId = pId, AlbumId = albumToAdd.Id });

            return RedirectToPage("./Index");
        }
    }
}
