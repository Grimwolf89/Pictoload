using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using MediatR;
using Application.Album.Commands.CreateAlbum;
using Application.Tags.Commands.CreateTag;
using Microsoft.AspNetCore.Identity;
using WebUI.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace Pictoload.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        readonly IMediator _mediator;

        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public Data.ApplicationDbContext _context { get; set; }

        public Application.Album.Commands.CreateAlbum.CreateAlbumCommand AlbumAdded { get; set; }

        public List<Domain.Entities.Album> AlbumsFromDb { get; set; }

        [BindProperty]
        public string userId { get; set; }
        
        public int albumId { get; set; }

        public IList<Domain.Entities.Album> Album { get; set; }

        /* public Album Album = new Album
         {
            *//* Id = 3,*//*
             AlbumTitle = "ItWorked"
         };
         private object x;*/

        public IndexModel(ILogger<IndexModel> logger, Data.ApplicationDbContext context, IMediator mediator, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _mediator = mediator;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public Domain.Entities.Share Share { get; set; }
        public async Task OnGetAsync()
        {
           /* UserIdx = _signInManager.UserManager.GetUserId(User).ToString();*/
            albumId = 5;
           /* userId = _userManager.GetUserId(User).ToString();*/
            _logger.LogDebug(userId);
            
            /*AlbumsFromDb = await _mediator.Send(new Application.Album.Queries.GetAlbumListQuery());*/
            Album = await _context.Albums.ToListAsync();
           /* Share.AlbumId = albumId;
            Share.UserId = userId;*/
        }

        [BindProperty]
        public Domain.Entities.Tag TagToAdd { get; set; }
       
       /* [BindProperty]*/
        /*public Domain.Entities.Album Album { get; set; }*/




        public async Task<IActionResult> OnPostAsync()
        {
            userId = _userManager.GetUserId(User).ToString();
            await _mediator.Send(new Application.Share.Commands.CreateShare.CreateShareCommand() { UserId = userId, AlbumId = 5 });
            /* await _mediator.Send(new Application.Album.Commands.CreateAlbum.CreateAlbumCommand() { Title = Album.AlbumTitle, ThumbnailPath = Album.ThumbnailPath });
             await _mediator.Send(new Application.Tags.Commands.CreateTag.CreateTagCommand() { TagTitle = TagToAdd.Title }); //Creat net tag command*/
            return RedirectToPage("Index");
        }

       

        


    }
}
