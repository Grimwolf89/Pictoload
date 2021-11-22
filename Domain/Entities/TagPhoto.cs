using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TagPhoto
    {
        public int Id { get; set; }

        public int PhotoId { get; set; }

        public int TagId { get; set; }

        /*public ICollection<Photo> Photos { get; set; }*/
    }
}
