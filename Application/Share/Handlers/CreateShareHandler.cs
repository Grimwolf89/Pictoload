using Application.Common.Interfaces;
using Application.Share.Commands.CreateShare;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Share.Handlers
{
    public class CreateShareHandler : IRequestHandler<CreateShareCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateShareHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateShareCommand request, CancellationToken cancellationToken)
        {


            var entity = new Domain.Entities.Share
            {
                UserId = request.UserId,
                AlbumId = request.AlbumId
                /*UserId = request.UserId,
                AlbumId = request.AlbumId*/ 
            };


            _context.Shares.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;

        }
    }
}

