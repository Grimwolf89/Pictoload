using Application.Common.Interfaces;
using Application.Tags.Commands.CreateTag;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Tags.EventHandlers
{
    public class CreateTagHandler : IRequestHandler<CreateTagCommand, int>
    {

        private IApplicationDbContext _context;
        public CreateTagHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            var tag = new Domain.Entities.Tag { Title = request.TagTitle };

            var x = _context.Tags.Add(tag);
            
            await _context.SaveChangesAsync(cancellationToken);

            return tag.Id;

           /* var entity = new Domain.Entities.Tag();
            entity.Title = request.TagTitle;

            _context.Tags.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;*/

            
        }
    }
}
