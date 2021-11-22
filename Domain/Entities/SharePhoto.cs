using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class SharePhoto
    {
        public int Id { get; set; }

        [ForeignKey("PhotoId")]
        public Photo Photo { get; set; }
        public int PhotoId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public string UserId { get; set; }
    }
}
