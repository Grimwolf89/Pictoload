using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Pictoload.Data;
using MediatR;
using System.IO;
using System.Net;
using System.Drawing;

namespace WebUI.Pages.Userdashboard
{
    public class PhotoDetailsModel : PageModel
    {
        private readonly Pictoload.Data.ApplicationDbContext _context;
        readonly IMediator _mediator;

        public PhotoDetailsModel(Pictoload.Data.ApplicationDbContext context, IMediator mediator )
        {
            _context = context;
            _mediator = mediator;
        }
        
        public Photo Photo { get; set; }
        public int PhotoId { get; set; }

        public IList<Tag> tagList { get; set; }
        [BindProperty]
        public string filePath { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Add GetPhoto by id query
            Photo = await _context.Photos
                .Include(p => p.User).FirstOrDefaultAsync(m => m.Id == id);


            
            tagList = await _mediator.Send(new Application.Tags.Queries.GetTagPhotosList.GetTagPhotosQuery() { PhotoId = id });
            

            if (Photo == null)
            {
                return NotFound();
            }
            return Page();

            

        }

       
    }
}
