using Application.Common.Interfaces;
using Application.Photo.Queries.GetUserPhotosList;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Photo.Handlers
{
    public class GetPhotoListHandler : IRequestHandler<GetUserPhotosListQuery, IList<Domain.Entities.Photo>>
    {
        private IApplicationDbContext _context;
        public IList<Domain.Entities.Photo> UserPhotos = new List<Domain.Entities.Photo>();

        public GetPhotoListHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Domain.Entities.Photo>> Handle(GetUserPhotosListQuery request, CancellationToken cancellationToken)
        {
            UserPhotos = await _context.Photos.Where(b => b.UserId == request.UserId).ToListAsync();
            return UserPhotos;
        }
    }
}
