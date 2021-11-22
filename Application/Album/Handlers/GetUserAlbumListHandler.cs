using Application.Album.Queries.GetUserAlbumsList;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace Application.Album.Handlers
{
    public class GetUserAlbumListHandler : IRequestHandler<GetUserAlbumListQuery, IList<Domain.Entities.Album>>
    {
        
        public string userId { get; set; }
        public IList<UserAlbums> UserAlbums = new List<UserAlbums>();
        public IList<Domain.Entities.Album> Albums = new List<Domain.Entities.Album>();
        private IApplicationDbContext _context;

        public GetUserAlbumListHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IList<Domain.Entities.Album>> Handle(GetUserAlbumListQuery request, CancellationToken cancellationToken)
        {

           UserAlbums = await _context.UserAlbums.Where(b => b.UserId == request.UserId).ToListAsync();
            
           foreach(var album in UserAlbums)
            {
                var AlbumToFind = await _context.Albums.FirstOrDefaultAsync(b => b.Id == album.Id);
                Albums.Add(AlbumToFind);
            }

           return Albums;
            
        }
    }
}
