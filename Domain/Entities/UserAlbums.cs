using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class UserAlbums
    {
        public int Id { get; set; }

        [ForeignKey("AlbumId")]
        public Album Album { get; set; }
        public int AlbumId { get; set; }


        [ForeignKey("UserId")]
        public User User { get; set; }
        public string UserId { get; set; }

        /*public ICollection<Album> Albums { get; set; }

        public ICollection<User> Users { get; set; }*/
    }
}
