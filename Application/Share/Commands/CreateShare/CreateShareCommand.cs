using MediatR;

namespace Application.Share.Commands.CreateShare
{
    public class CreateShareCommand : IRequest<int>
    {
        public int UserId { get; set; }
        public int AlbumId { get; set; }

    }
}
