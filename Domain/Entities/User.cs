using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : IdentityUser
    {
        /*public override string Id { get; set; }*/
        /* public string FirstName { get; set; }

         public string Lastname { get; set; }*/

        public ICollection<Album> Albums { get; set; }
        public ICollection<Share> Shares { get; set; }


    }
}
