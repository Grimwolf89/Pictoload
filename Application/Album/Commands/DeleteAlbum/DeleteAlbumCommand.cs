using MediatR;

namespace Application.Album.Commands.DeleteAlbum
{
    public class DeleteAlbumCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
