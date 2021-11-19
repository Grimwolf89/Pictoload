using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage;
using Pictoload.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Drawing;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace WebUI.Pages.Userdashboard
{
    public class ImageUploadModel : PageModel
    {

        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _environment;
        private readonly ILogger<ImageUploadModel> _logger;
        readonly IMediator _mediator;
        private readonly SignInManager<IdentityUser> _signInManager;

        CloudStorageAccount _storageAccount = CloudStorageAccount.Parse("XX");
        
        [BindProperty(SupportsGet = true)]
        public string FileName { get; set; }
        public string userId { get; set; }
        [BindProperty]
        public Domain.Entities.Photo Photo { get; set; }
        public int UploadPhoto { get; set; }
        public IList<string> Tags { get; set; }

        [BindProperty]
        public string TagString { get; set; }

        [BindProperty]
        public bool NewAlbum { get; set; }

        public ImageUploadModel(ApplicationDbContext context, IHostingEnvironment environment, ILogger<ImageUploadModel> logger, SignInManager<IdentityUser> signInManager, IMediator mediator)
        {
            _context = context;
            _environment = environment;
            _logger = logger; 
            _signInManager = signInManager;
            _mediator = mediator;
        }

        
        public string imageFullPath { get; set; }
        public void OnGetAsync()
        {
            userId = _signInManager.UserManager.GetUserId(User);
            if (FileName != null)
            {
                CloudBlobClient cloudBlobClient = _storageAccount.CreateCloudBlobClient();

                CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference("images");

                CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(FileName);

               

                imageFullPath = cloudBlockBlob.Uri.ToString();
            }
            // Retrieve Image from storage via blob link
           
            

            
           
  
            

          
        }

        public async Task<IActionResult> OnPostAsync()
        {
           

            //Add Photo to db
            userId = _signInManager.UserManager.GetUserId(User);
            int PhotoId = await _mediator.Send(new Application.Photo.Commands.CreatePhoto.CreatePhotoCommand() { Name = Photo.Name, CapturedBy = Photo.CapturedBy, DateCaptured = Photo.DateCaptured, GeoLocation = Photo.Geolocation, ImagePath = FileName, UserId = userId });

            //Generate list of tags and add to database if not exists
            if (TagString != null)
            {
                Tags = TagString.Split(',').Select(t => t).ToList();

                foreach (var tag in Tags)
                {
                    int AddTag = await _mediator.Send(new Application.Tags.Commands.CreateTag.CreateTagCommand() { Title = tag.ToString() });
                    //Add command to link photo with tag ***************
                    int ShareTag = await _mediator.Send(new Application.Tags.Commands.TagPhoto.TagPhotoCommand() { PhotoId = PhotoId, TagId = AddTag });

                }
            }
            return RedirectToPage("./Index");
        }

    }
}
