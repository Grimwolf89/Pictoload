using Application.Common.Interfaces;
using Application.Photo.Commands.CreatePhoto;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Photo.Handlers
{
    public class CreatePhotoHandler : IRequestHandler<CreatePhotoCommand, int>
    {

        private readonly IApplicationDbContext _context;

        public CreatePhotoHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreatePhotoCommand request, CancellationToken cancellationToken)
        {
            var entity = new Domain.Entities.Photo
            {
                Name = request.Name,
                Geolocation = request.GeoLocation,
                DateCaptured = request.DateCaptured,
                CapturedBy = request.CapturedBy,
                ImagePath = request.ImagePath,
                UserId = request.UserId
                
            };

            /*var entity = new Domain.Entities.Photo
            {               
                Name = request.Name,
                Geolocation = request.GeoLocation,
                DateCaptured = request.DateCaptured,
                CapturedBy = request.CapturedBy,
                ImagePath = request.ImagePath,
                UserId = request.UserId
            };*/

            _context.Photos.Add(entity);    
            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
            
        }
    }
}
