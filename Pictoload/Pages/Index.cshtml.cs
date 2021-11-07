using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;



namespace Pictoload.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;


        public Data.ApplicationDbContext _context { get; set; }

        

        public Album Album = new Album
        {
           /* Id = 3,*/
            AlbumTitle = "Testicles"
        };


        public IndexModel(ILogger<IndexModel> logger, Data.ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            
        }

        public async Task OnGetAsync()
        {
            _context.Albums.Add(Album);

            await _context.SaveChangesAsync();
        }
    }
}
