using Application.Common.Interfaces;
using Application.Tags.Queries.GetTagPhotosList;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Tags.Commands.Handlers
{
    public class GetTagPhotosListHandler : IRequestHandler<GetTagPhotosQuery, IList<Domain.Entities.Tag>>
    {
        private readonly IApplicationDbContext _context;
        public IList<Domain.Entities.TagPhoto> PhotoTags = new List<Domain.Entities.TagPhoto>();
        public IList<Tag> Tags = new List<Tag>();


        public GetTagPhotosListHandler(IApplicationDbContext data)
        {
            _context = data;
        }
        public async Task<IList<Tag>> Handle(GetTagPhotosQuery request, CancellationToken cancellationToken)
        {
           PhotoTags = await _context.TagPhotos.Where(b => b.PhotoId == request.PhotoId).ToListAsync();
            
            foreach(var tag in PhotoTags)
            {
                var tagToAdd = await _context.Tags.FirstOrDefaultAsync(b => b.Id == tag.Id);
                Tags.Add(tagToAdd);
            }
            return Tags;
        }
    }
}
