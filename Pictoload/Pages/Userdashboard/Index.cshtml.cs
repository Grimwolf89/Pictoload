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
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace WebUI.Pages.Userdashboard
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private IHostingEnvironment _environment;
        readonly IMediator _mediator;

       

        //Cloud Storage
        CloudStorageAccount _storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=cmpgfiles;AccountKey=nwadM8aExocz2w/u3f0LGTwzLJCgs1O6ro1CnFuYWrepgOnBkgcT5yYhlcz5TzBVpXm1t1tIPI+oTzV18zpFOw==;EndpointSuffix=core.windows.net");

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public string Username { get; set; }

        [BindProperty]
        public IFormFile Upload { get; set; }

        [BindProperty]
        public string userId { get; set; }

        [BindProperty]
        public string imageFullPath { get; set; }

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
        public IList<Photo> userPhotos { get; set; }
        public IList<Photo> SharedPhotos { get; set; }




        public async Task OnGetAsync()
        {

            userId = _signInManager.UserManager.GetUserId(User);
           
           
            SharedAlbums = await _mediator.Send(new Application.Album.Queries.GetSharedAlbumsList.GetSharedAlbumListQuery() { UserId = userId });
            UserAlbums = await _mediator.Send(new Application.Album.Queries.GetUserAlbumsList.GetUserAlbumListQuery() { UserId = userId });
            userPhotos = await _mediator.Send(new Application.Photo.Queries.GetUserPhotosList.GetUserPhotosListQuery() { UserId = userId });
            SharedPhotos = await _mediator.Send(new Application.Photo.Queries.GetSharedPhotoList.GetSharedPhotoListQuery() { UserId = userId});



        }



        public async Task<IActionResult> OnPostAsync()
        {

            // Upload Image to storage
            CloudBlobClient cloudBlobClient = _storageAccount.CreateCloudBlobClient();
            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference("images");

            if (Upload.FileName != "")
            {
                string ImageName = Guid.NewGuid().ToString() + "-" + Upload.FileName.ToString();
                CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(ImageName);
                cloudBlockBlob.Properties.ContentType = Upload.ContentType;

                await cloudBlockBlob.UploadFromStreamAsync(Upload.OpenReadStream());
                imageFullPath = cloudBlockBlob.Uri.ToString();
                Console.WriteLine(imageFullPath);

                return RedirectToPage("./ImageUpload", new { FileName = imageFullPath }); ;
            }

            return Page();
            

            

           
        }
    }
}
