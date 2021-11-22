using MediatR;
using System.Collections.Generic;

namespace Application.Album.Queries.GetSharedAlbumsList
{
    public class GetSharedAlbumListQuery : IRequest<IList<Domain.Entities.Album>>
    {
        public string UserId { get; set; }
    }
}
