using Application.Common.Interfaces;
using Application.Photo.Commands.SharePhoto;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Photo.Handlers
{
    public class SharePhotoHandler : IRequestHandler<SharePhotoCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public SharePhotoHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(SharePhotoCommand request, CancellationToken cancellationToken)
        {

            var entity = new Domain.Entities.SharePhoto
            {
                UserId = request.UserId,
                PhotoId = request.PhotoId
            };

            _context.SharePhotos.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
