using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Photo
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Geolocation { get; set; }
        public DateTime DateCaptured { get; set; }
        public string CapturedBy { get; set; }
        public string ImagePath { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public string UserId { get; set; }
        public ICollection<TagPhoto> TagPhoto { get; set; }
       /* public ICollection<SharePhoto> SharePhotos { get; set; }*/

        /* public ICollection<Album> Albums { get; set; }*/
    }
}
