using Application.Common.Interfaces;
using Application.Photo.Queries.GetPhotoById;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Photo.Handlers
{
    public class GetPhotoByIdHandler : IRequestHandler<GetPhotoByIdCommand, Domain.Entities.Photo>
    {
        private readonly IApplicationDbContext _context;

        public Domain.Entities.Photo Photo { get; set; }

        public GetPhotoByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Domain.Entities.Photo> Handle(GetPhotoByIdCommand request, CancellationToken cancellationToken)
        {
            var entity = new Domain.Entities.Photo()
            {
                Id = request.PhotoId
            };

            Photo = _context.Photos.Find(request.PhotoId);
            return Photo;

        }
    }
}
