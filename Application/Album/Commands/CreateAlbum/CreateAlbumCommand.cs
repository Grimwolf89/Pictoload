using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Album.Commands.CreateAlbum
{
    public class CreateAlbumCommand : IRequest<int>
    {
       

        public string Title { get; set; }
        public string ThumbnailPath { get; set; }
        public int UserId { get; set; }
        public string TagTitle { get; }

        
    }


}
