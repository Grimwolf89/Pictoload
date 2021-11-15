using MediatR;

namespace Application.Album.Queries
{
    public class GetAlbumByUserIdQuery : IRequest<Domain.Entities.Album>
    {
        public int UserId { get; set; }

        public GetAlbumByUserIdQuery(int id)
        {
            UserId = id;
        }
    }
}
