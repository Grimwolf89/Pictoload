using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class PhotoAlbum
    {
        public int Id { get; set; }

        [ForeignKey("AlbumId")]
        public Album Album { get; set; }
        public int AlbumId { get; set; }

        [ForeignKey("PhotoId")]
        public Photo Photo { get; set; }
        public int PhotoId { get; set; }

      /*  public ICollection<Album> Albums { get; set; }

        public ICollection<Photo> Photos { get; set; }*/

    }
}
