using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using System.Threading;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext 
    {
        DbSet<Domain.Entities.Album> Albums { get; set; }
        DbSet<Photo> Photos { get; set; }
        public DbSet<Share> Shares { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagPhoto> TagPhotos { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}
