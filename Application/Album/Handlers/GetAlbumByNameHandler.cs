using Application.Album.Queries.GetAlbumByName;
using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Album.Handlers
{
    public class GetAlbumByNameHandler : IRequestHandler<GetAlbumByNameQuery, Domain.Entities.Album>
    {
        private IApplicationDbContext _context;

        public List<Domain.Entities.Album> albums { get; set; }
        public Domain.Entities.Album Album { get; set; }
        public GetAlbumByNameHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Domain.Entities.Album> Handle(GetAlbumByNameQuery request, CancellationToken cancellationToken)
        {
            string albumName = request.AlbumName;
            string userId = request.UserId;
            //Check if user has album with name

            var userAlbums = await _context.UserAlbums.Where(p => p.UserId == userId).ToListAsync();

            foreach(var album in userAlbums)
            {
                var AlbumToFind = await _context.Albums.FirstOrDefaultAsync(a => a.Id == album.Id);

                if (AlbumToFind != null)
                {
                    if (AlbumToFind.AlbumTitle == albumName)
                    {
                        Album = AlbumToFind;
                    }
                }
               
            }
            return Album;
            
            
        }
    }
}
