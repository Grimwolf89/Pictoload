using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Pictoload.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Identity;
using WebUI.Areas.Identity.Data;
using MediatR;

namespace WebUI.Pages.Userdashboard
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private IHostingEnvironment _environment;
        readonly IMediator _mediator;


        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public string Username { get; set; }


       

        [BindProperty]
        public IFormFile Upload { get; set; }

        [BindProperty]
        public string userId { get; set; }
        [BindProperty]
        public string userx { get; private set; }

        public IndexModel(ApplicationDbContext context, IHostingEnvironment environment, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IMediator mediator)
        {
            _context = context;
            _environment = environment;
            _userManager = userManager;
            _signInManager = signInManager;
            _mediator = mediator;
        }

        public IList<Album> Album { get; set; }
        public IList<Album> UserAlbums { get; set; }
        public IList<Album> SharedAlbums { get; set; }
       

        


        public async Task OnGetAsync()
        {

            userId = User.Identity.Name;
            userx = _signInManager.UserManager.GetUserId(User);
            /*SharedAlbums = await _mediator.Send(new Application.Album.Queries.GetSharedAlbumsList.GetSharedAlbumListQuery() { UserId = userx });*/
            SharedAlbums = await _mediator.Send(new Application.Album.Queries.GetSharedAlbumsList.GetSharedAlbumListQuery() { UserId = userx });
            UserAlbums = await _mediator.Send(new Application.Album.Queries.GetUserAlbumsList.GetUserAlbumListQuery() { UserId = userx });
            
            /* Album = await _context.Albums.ToListAsync();   */
            /* await _mediator.Send(new Application.Album.Commands.CreateAlbum.CreateAlbumCommand() { Title = Album.AlbumTitle, ThumbnailPath = Album.ThumbnailPath });
             await _mediator.Send(new Application.Tags.Commands.CreateTag.CreateTagCommand() { TagTitle = TagToAdd.Title }); //Creat net tag command*/
        }



        public async Task<IActionResult> OnPostAsync()
        {

            //Upload File to temp folder before adding metadata
            string TempFileName = Path.GetRandomFileName();
            string FullTempFileName = $"{TempFileName}-{Upload.FileName}";

            string file = Path.Combine($"{_environment.ContentRootPath}/wwwroot/Images/Temp/{ TempFileName}-{ Upload.FileName}");

            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await Upload.CopyToAsync(fileStream);
            }

            return RedirectToPage("./ImageUpload", new { FileName = FullTempFileName });

           
        }
    }
}
