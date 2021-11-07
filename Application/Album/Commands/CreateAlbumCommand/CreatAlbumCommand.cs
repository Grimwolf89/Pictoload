using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Album.Commands.CreateAlbumCommand
{
    public class CreatAlbumCommand : IRequest<int>
    {

        public int AlbumId { get; set; }
        public string AlbumTitle { get; set; } 
        
    }

    public class CreateAlbumCommandHandler : IRequestHandler<CreatAlbumCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public async Task<int> Handle(CreatAlbumCommand request, CancellationToken cancellationToken)
        {
            var entity = new Domain.Entities.Album
            {
                Id = request.AlbumId,
                AlbumTitle = request.AlbumTitle
            };

            /* throw new NotImplementedException();*/

            _context.Albums.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
