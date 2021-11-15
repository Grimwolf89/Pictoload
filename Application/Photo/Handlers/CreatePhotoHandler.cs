using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Photo.Commands.CreatePhoto;
using Domain.Entities;
using System.Collections.Generic;

namespace Application.Photo.Handlers
{
    public class CreatePhotoHandler : IRequestHandler<CreatePhotoCommand, int>
    {
        public Domain.Entities.Photo Photo { get; set; }
        public User User { get; set; }
        public Tag Tag { get; set; }
        public TagPhoto TagPhoto { get; set; }
        public Domain.Entities.Album Album { get; set; }
        public List<Domain.Entities.Album> AlbumList { get; set; }

        private readonly IApplicationDbContext _context;
        public CreatePhotoHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public Task<int> Handle(CreatePhotoCommand request, CancellationToken cancellationToken)
        {



            

            throw new System.NotImplementedException();
        }
    }
}
