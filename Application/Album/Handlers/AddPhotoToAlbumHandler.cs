using Application.Album.Commands.AddPhotoToAlbum;
using Application.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Album.Handlers
{
    public class AddPhotoToAlbumHandler : IRequestHandler<AddPhotoToAlbumCommand, int>
    {
        private readonly IApplicationDbContext _context;
        public AddPhotoToAlbumHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(AddPhotoToAlbumCommand request, CancellationToken cancellationToken)
        {
            var entity = new Domain.Entities.PhotoAlbum
            {
                PhotoId = request.PhotoId,
                AlbumId = request.AlbumId,
            };

            _context.PhotoAlbums.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
