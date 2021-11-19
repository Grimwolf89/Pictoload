using MediatR;
using System;

namespace Application.Photo.Commands.CreatePhoto
{
    public class CreatePhotoCommand : IRequest<int>
    {
       
        public string Name { get; set; }
        public string GeoLocation { get; set; }
        public DateTime DateCaptured { get; set; }
        public string CapturedBy { get; set; }
        public string ImagePath { get; set; }
        public string UserId { get; set; }
    }
}
