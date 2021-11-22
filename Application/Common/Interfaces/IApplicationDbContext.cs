using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using System.Threading;
using Microsoft.AspNetCore.Identity;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext 
    {
        public DbSet<Domain.Entities.Album> Albums { get; set; }
        public DbSet<Domain.Entities.Photo> Photos { get; set; }
        public DbSet<Domain.Entities.Share> Shares { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagPhoto> TagPhotos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PhotoAlbum> PhotoAlbums { get; set; }
        public DbSet<UserAlbums> UserAlbums { get; set; }
        public DbSet<SharePhoto> SharePhotos { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

       /* Domain.Entities.Tag InsertTag(string tagTitle)
        {
            Domain.Entities.Tag tag = new Domain.Entities.Tag() { Title = tagTitle };

            Tags.Add(tag);

            return tag;
        }*/

      
    }
}
