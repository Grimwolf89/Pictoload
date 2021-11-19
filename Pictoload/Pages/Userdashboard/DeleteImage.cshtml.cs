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
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.IO;

namespace WebUI.Pages.Userdashboard
{
    public class DeleteImageModel : PageModel
    {
        private readonly Pictoload.Data.ApplicationDbContext _context;
        readonly IMediator _mediator;
        CloudStorageAccount _storageAccount = CloudStorageAccount.Parse("XXX");
        public DeleteImageModel(Pictoload.Data.ApplicationDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public CloudBlockBlob cloudBlockBlob { get; set; }

        [BindProperty]
        public Photo Photo { get; set; }
        public string filename { get; private set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Photo = await _context.Photos
                .Include(p => p.User).FirstOrDefaultAsync(m => m.Id == id);

            if (Photo == null)
            {
                return NotFound();
            }

            CloudBlobClient cloudBlobClient = _storageAccount.CreateCloudBlobClient();

            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference("images");

            string pathx = Photo.ImagePath;
            filename = Path.GetFileName(pathx);

            cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(filename);
            
            
            
            await cloudBlockBlob.DeleteAsync();
            
            return Page();

        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            
            
           

            await _mediator.Send(new Application.Photo.Commands.DeletePhoto.DeletePhotoCommand() { Id = Photo.Id});

            return RedirectToPage("./Index");
        }
    }
}
