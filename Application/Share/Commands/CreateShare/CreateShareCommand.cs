using MediatR;

namespace Application.Share.Commands.CreateShare
{
    public class CreateShareCommand : IRequest<int>
    {
        public string UserId { get; set; }
        public int AlbumId { get; set; }

        public Domain.Entities.Album Album { get; set; }
        public Domain.Entities.User User { get; set; }

    }
}
