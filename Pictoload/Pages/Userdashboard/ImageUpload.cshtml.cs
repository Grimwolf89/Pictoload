using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Pictoload.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebUI.Pages.Userdashboard
{
    public class ImageUploadModel : PageModel
    {

        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _environment;

        private readonly ILogger<ImageUploadModel> _logger;
        readonly IMediator _mediator;

        [BindProperty(SupportsGet = true)]
        public string FileName { get; set; }
        public string ImagePath { get; set; }

       /* public List<Domain.Entities.Album> AlbumsList { get; set; }*/

        //Bring in a list of existing albums to list on the page
        //If there are no albums in the list, only offer option on page to create a new album
        //Create a new album on post
       

       

        public ImageUploadModel(ApplicationDbContext context, IHostingEnvironment environment, ILogger<ImageUploadModel> logger)
        {
            _context = context;
            _environment = environment;
            _logger = logger;   
        }
        public async Task OnGetAsync()
        {
            ImagePath = $"/Images/Temp/{FileName}";

           /* AlbumsList = await _mediator.Send(new Application.Album.Queries.GetAlbumListQuery());*/
        }
    }
}
