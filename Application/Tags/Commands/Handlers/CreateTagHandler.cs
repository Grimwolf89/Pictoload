using Application.Common.Interfaces;
using Application.Tags.Commands.CreateTag;
using Domain.Entities;
using MediatR;
using System.Linq;
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
            //Check if tag is already in db
            var entityExists = _context.Tags.Where(t => t.Title == request.Title).FirstOrDefault();

            if (entityExists == null)
            {
                //Add the tag if not in db
                var entity = new Domain.Entities.Tag { Title = request.Title };
                _context.Tags.Add(entity);

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
