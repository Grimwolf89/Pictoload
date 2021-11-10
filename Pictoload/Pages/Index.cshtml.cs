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


namespace Pictoload.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        readonly IMediator _mediator;

        public Data.ApplicationDbContext _context { get; set; }

        public Application.Album.Commands.CreateAlbum.CreateAlbumCommand AlbumAdded { get; set; }

        public List<Domain.Entities.Album> AlbumsFromDb { get; set; }

        public Album Album = new Album
        {
           /* Id = 3,*/
            AlbumTitle = "ItWorked"
        };
        private object x;

        public IndexModel(ILogger<IndexModel> logger, Data.ApplicationDbContext context, IMediator mediator)
        {
            _logger = logger;
            _context = context;
            _mediator = mediator;
        }

        public async Task OnGetAsync()
        {

            

            AlbumsFromDb = await _mediator.Send(new Application.Album.Queries.GetAlbumListQuery());
            


        }


    }
}
