using MediatR;
using System.Collections.Generic;

namespace Application.Photo.Queries.GetUserPhotosList
{
    public class GetUserPhotosListQuery : IRequest<IList<Domain.Entities.Photo>>
    {
        public string UserId { get; set; }
    }
}
