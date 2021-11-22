using MediatR;
namespace Application.Photo.Queries.GetPhotoById
{
    public class GetPhotoByIdCommand : IRequest<Domain.Entities.Photo>
    {
        public int PhotoId { get; set; }
    }
}
