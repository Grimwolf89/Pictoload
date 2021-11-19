using Application.Album.Commands.DeleteAlbum;
using Application.Common.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Album.Handlers
{
    public class DeleteAlbumHandler : IRequestHandler<DeleteAlbumCommand, int>
    {
        private IApplicationDbContext _context;

        /*ublic Domain.Entities.Album Album = new Domain.Entities.Album();*/
        public DeleteAlbumHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteAlbumCommand request, CancellationToken cancellationToken)
        {

            var entity = await _context.Albums.FindAsync(new object[] { request.Id }, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Domain.Entities.Album), request.Id);
            }

            _context.Albums.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return 0;
        }
    }
}
