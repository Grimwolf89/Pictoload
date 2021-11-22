using Application.Album.Handlers;
using Application.Common.Interfaces;
using Application.Photo.Commands.DeletePhoto;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Photo.Handlers
{
    public class DeletePhotoHandler : IRequestHandler<DeletePhotoCommand, int>
    {
        private IApplicationDbContext _context;

        public DeletePhotoHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeletePhotoCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Photos.FindAsync(new object[] { request.Id }, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Domain.Entities.Photo), request.Id);
            }

            _context.Photos.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return 0;

        }
    }
}
