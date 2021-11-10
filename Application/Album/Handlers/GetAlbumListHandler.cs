using Application.Album.Queries;
using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Album.Handlers
{
    public class GetAlbumListHandler : IRequestHandler<GetAlbumListQuery, List<Domain.Entities.Album>>
    {
        private readonly IApplicationDbContext _context;

        
        public GetAlbumListHandler(IApplicationDbContext data)
        {
            _context = data;
        }

        public async Task<List<Domain.Entities.Album>> Handle(GetAlbumListQuery request, CancellationToken cancellationToken)
        {
            /* throw new NotImplementedException();*/

            var Lists = await _context.Albums.ToListAsync(cancellationToken);

            return Lists;
        }
    }
}
