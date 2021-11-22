using MediatR;
using System.Collections.Generic;

namespace Application.Tags.Queries.GetTagPhotosList
{
    public class GetTagPhotosQuery : IRequest<IList<Domain.Entities.Tag>>
    {
        public int PhotoId { get; set; }
    }
}
