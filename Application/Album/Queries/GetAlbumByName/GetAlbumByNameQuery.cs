using MediatR;

namespace Application.Album.Queries.GetAlbumByName
{
    public class GetAlbumByNameQuery : IRequest<Domain.Entities.Album>
    {
        public string AlbumName { get; set; }

        public string UserId { get; set; }
    }
}
