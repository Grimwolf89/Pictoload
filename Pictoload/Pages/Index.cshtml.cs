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
using Application.Album.Commands.CreateAlbum;
using Application.Tags.Commands.CreateTag;
using Microsoft.AspNetCore.Identity;
using WebUI.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace Pictoload.Pages
{
    public class IndexModel : PageModel
    {
       


   
      
        public IActionResult OnGet()
        {
          if (User.Identity.IsAuthenticated)
            {
                return LocalRedirect("/Userdashboard");
            }
            return Page();
        }

      
       

    }
}
