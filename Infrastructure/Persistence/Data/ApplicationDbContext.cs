using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
/*using System.Data.Entity.ModelConfiguration.Conventions;*/
using System.Text;

namespace Pictoload.Data
{
    public class ApplicationDbContext : IdentityDbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Share> Shares { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagPhoto> TagPhotos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PhotoAlbum> PhotoAlbums { get; set; }

        public DbSet<UserAlbums> UserAlbums { get; set; }




    }


}
