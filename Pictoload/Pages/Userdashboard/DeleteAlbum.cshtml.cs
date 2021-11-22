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

namespace WebUI.Pages.Userdashboard
{
    public class DeleteAlbumModel : PageModel
    {
        private readonly Pictoload.Data.ApplicationDbContext _context;
        readonly IMediator _mediator;
        public DeleteAlbumModel(Pictoload.Data.ApplicationDbContext context , IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        [BindProperty]
        public Album Album { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Album = await _context.Albums.FirstOrDefaultAsync(m => m.Id == id);

            if (Album == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {

            await _mediator.Send(new Application.Album.Commands.DeleteAlbum.DeleteAlbumCommand() { Id = Album.Id });

            return RedirectToPage("./Index");
        }
    }
}
