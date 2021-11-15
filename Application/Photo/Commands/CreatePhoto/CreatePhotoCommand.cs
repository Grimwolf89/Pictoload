using MediatR;
using System;

namespace Application.Photo.Commands.CreatePhoto
{
    public class CreatePhotoCommand : IRequest<int>
    {
        public Domain.Entities.Photo Photo { get; set; }
        public Domain.Entities.Album Album { get; set; }
        public Domain.Entities.Tag Tag { get; set; }
        public Domain.Entities.TagPhoto TagPhoto { get; set; }
        public Domain.Entities.User User { get; set; }



       /* //Photo 
        public string Geolocation { get; set; }
        public DateTime DateCaptured { get; set; }
        public string CapturedBy { get; set; }
        public string ImagePath { get; set; }

        //Album 
        public int AlbumId { get; set; }
        public string AlbumTitle { get; set; }
        public string ThumbnailPath { get; set; }

        //Tags
        public int TagId { get; set; }
        public string TagTitle { get; set; }*/
    }
}
