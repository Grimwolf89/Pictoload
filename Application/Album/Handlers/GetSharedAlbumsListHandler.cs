using Application.Album.Queries.GetSharedAlbumsList;
using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Album.Handlers
{
    public class GetSharedAlbumsListHandler : IRequestHandler<GetSharedAlbumListQuery, IList<Domain.Entities.Album>>
    {
        public string userId { get; set; }
        public IList<Domain.Entities.Share> SharedAlbums = new List<Domain.Entities.Share>();
        public IList<Domain.Entities.Album> Albums = new List<Domain.Entities.Album>();
        private IApplicationDbContext _context;

        public GetSharedAlbumsListHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Domain.Entities.Album>> Handle(GetSharedAlbumListQuery request, CancellationToken cancellationToken)
        {
            /*SharedAlbums = await _context.Shares.Where(b => b.UserId == request.UserId).ToListAsync();*/
            SharedAlbums = await _context.Shares.Where(b => b.UserId == request.UserId).ToListAsync();
            

            foreach (var album in SharedAlbums)
            {
                var AlbumToFind = await _context.Albums.FirstOrDefaultAsync(b => b.Id == album.AlbumId);
                Albums.Add(AlbumToFind);
            }

            return Albums;
            
        }
    }
}
