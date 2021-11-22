using Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Application.Album.Queries.GetUserAlbumsList
{
    public class GetUserAlbumListQuery : IRequest<IList<Domain.Entities.Album>>
    {
        public string UserId { get; set; }
    }
}
