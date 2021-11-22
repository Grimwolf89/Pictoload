using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Album 
    {
        public int Id { get; set; }
        public string AlbumTitle { get; set; }
        public string ThumbnailPath { get; set; }
        /*public ICollection<Photo> Photos { get; set; }*/
        public ICollection<Share> Shares { get; set; }
    }
}
