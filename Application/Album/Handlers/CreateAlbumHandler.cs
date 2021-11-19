using Application.Album.Commands.CreateAlbum;
using Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Album.Handlers
{
    public class CreateAlbumHandler : IRequestHandler<CreateAlbumCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateAlbumHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateAlbumCommand request, CancellationToken cancellationToken)
        {
            var entity = new Domain.Entities.Album { 
                AlbumTitle = request.Title,
                ThumbnailPath = request.ThumbnailPath
            };

           
            
            _context.Albums.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;

           
        }
    }
}
