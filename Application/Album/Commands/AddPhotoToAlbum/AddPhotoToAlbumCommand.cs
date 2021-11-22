using MediatR;

namespace Application.Album.Commands.AddPhotoToAlbum
{
    public class AddPhotoToAlbumCommand : IRequest<int>
    {
        public int PhotoId { get; set; }
        public int AlbumId { get; set; }
    }
}
