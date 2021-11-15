using Application.Album.Queries;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Album.Handlers
{
    public class GetAlbumByUserIdHandler : IRequestHandler<GetAlbumByUserIdQuery, Domain.Entities.Album>
    {
        public Task<Domain.Entities.Album> Handle(GetAlbumByUserIdQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
