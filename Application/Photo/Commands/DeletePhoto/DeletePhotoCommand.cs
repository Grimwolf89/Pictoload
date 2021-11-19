using MediatR;

namespace Application.Photo.Commands.DeletePhoto
{
    public class DeletePhotoCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
