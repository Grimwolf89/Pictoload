using MediatR;

namespace Application.Tags.Commands.TagPhoto
{
    public class TagPhotoCommand : IRequest<int>
    {
        public int PhotoId { get; set; }
        public int TagId { get; set; }
    }
}
