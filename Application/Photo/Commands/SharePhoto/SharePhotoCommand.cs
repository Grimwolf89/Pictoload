using MediatR;

namespace Application.Photo.Commands.SharePhoto
{
    public class SharePhotoCommand : IRequest<int>
    {
        public string UserId { get; set; }
        public int PhotoId { get; set; }
    }
}
