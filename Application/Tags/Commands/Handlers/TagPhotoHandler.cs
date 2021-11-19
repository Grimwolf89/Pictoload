using Application.Common.Interfaces;
using Application.Tags.Commands.TagPhoto;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Tags.Commands.Handlers
{
    public class TagPhotoHandler : IRequestHandler<TagPhotoCommand, int>
    {
        private readonly IApplicationDbContext _context;
        public TagPhotoHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(TagPhotoCommand request, CancellationToken cancellationToken)
        {
            var entityExists = _context.TagPhotos.Where(t => t.TagId == request.TagId && t.PhotoId == request.PhotoId ).FirstOrDefault();

            if (entityExists == null)
            {
                //Add the PhotoTag if not in db
                var entity = new Domain.Entities.TagPhoto { PhotoId = request.PhotoId, TagId = request.TagId };
                _context.TagPhotos.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.Id;
            }
            else
            {
                return entityExists.Id;
            }

        }
    }
}
