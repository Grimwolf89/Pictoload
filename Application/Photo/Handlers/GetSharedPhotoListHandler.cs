using Application.Common.Interfaces;
using Application.Photo.Queries.GetSharedPhotoList;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Photo.Handlers
{
    public class GetSharedPhotoListHandler : IRequestHandler<GetSharedPhotoListQuery, IList<Domain.Entities.Photo>>
    {
        private IApplicationDbContext _context;
        public IList<Domain.Entities.SharePhoto> SharePhotos = new List<Domain.Entities.SharePhoto>();
        public IList<Domain.Entities.Photo> Photos = new List<Domain.Entities.Photo>();
        

        public GetSharedPhotoListHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Domain.Entities.Photo>> Handle(GetSharedPhotoListQuery request, CancellationToken cancellationToken)
        {
            SharePhotos = await _context.SharePhotos.Where(b => b.UserId == request.UserId).ToListAsync();
            foreach(var photo in SharePhotos)
            {
                var PhotoToFind = await _context.Photos.FirstOrDefaultAsync(b => b.Id == photo.PhotoId);
                Photos.Add(PhotoToFind);
            }

            return Photos;
        }
    }
}
