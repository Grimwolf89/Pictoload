using MediatR;
using System.Collections.Generic;

namespace Application.Photo.Queries.GetSharedPhotoList
{
    public class GetSharedPhotoListQuery : IRequest<IList<Domain.Entities.Photo>>
    {
        public string UserId { get; set; }
    }
}
