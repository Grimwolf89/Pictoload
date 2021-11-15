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

namespace WebUI.Pages.Userdashboard
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private IHostingEnvironment _environment;


        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public string Username { get; set; }


        /* public UserManager<User> _userManager { get; }*/

        [BindProperty]
        public IFormFile Upload { get; set; }

        [BindProperty]
        public string userId { get; set; }
        [BindProperty]
        public string userx { get; private set; }

        public IndexModel(ApplicationDbContext context, IHostingEnvironment environment, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _environment = environment;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IList<Album> Album { get; set; }
       

        


        public async Task OnGetAsync()
        {

            userId = User.Identity.Name;
            userx = _signInManager.UserManager.GetUserId(User);
            Album = await _context.Albums.ToListAsync();         
            
        }


        
        public async Task<IActionResult> OnPostAsync()
        {

            //Upload File to temp folder before adding metadata
            string TempFileName = Path.GetRandomFileName();
            string FullTempFileName = $"{TempFileName}-{Upload.FileName}";

            string file = Path.Combine($"{_environment.ContentRootPath}/wwwroot/Images/Temp/{ TempFileName}-{ Upload.FileName}");

            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await Upload.CopyToAsync(fileStream);
            }

            return RedirectToPage("./ImageUpload", new { FileName = FullTempFileName });

           
        }
    }
}
