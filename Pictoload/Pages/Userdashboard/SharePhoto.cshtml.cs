using Application.Common.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pictoload.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Pages.Userdashboard
{
    public class SharePhotoModel : PageModel
    {
        private ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        readonly IMediator _mediator;
        

        [BindProperty]
        public string userId { get; set; }

        [BindProperty(SupportsGet =true)]
        public string photoId { get; set; }

        [BindProperty]
        public string selectedUser  { get; set; }

        public Domain.Entities.Photo Photo { get; set; }

        public SharePhotoModel(ApplicationDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IMediator mediator)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _mediator = mediator;
            
        }
        /*[BindProperty]*/
        public List<IdentityUser> identityUsers { get; set; }
        public IdentityUser ShareUser { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            photoId = id.ToString();
            identityUsers = _userManager.Users.ToList();
            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
           
            selectedUser = Request.Form["selectedUser"];
            photoId = Request.Form["photoId"];

            int ide = int.Parse(photoId);
         
            ShareUser = await _userManager.FindByNameAsync(selectedUser);
            Photo = await _mediator.Send(new Application.Photo.Queries.GetPhotoById.GetPhotoByIdCommand() { PhotoId = ide });

            var idx = photoId;
            await _mediator.Send(new Application.Photo.Commands.SharePhoto.SharePhotoCommand() { UserId = ShareUser.Id, PhotoId = ide });           

            return RedirectToPage("./Index");
        }
    }
}
