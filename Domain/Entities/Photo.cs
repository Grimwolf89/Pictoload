using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public string Geolocation { get; set; }
        public DateTime DateCaptured { get; set; }
        public string CapturedBy { get; set; }
        public string ImagePath { get; set; }
    }
}
