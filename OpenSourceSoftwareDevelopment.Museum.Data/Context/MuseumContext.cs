using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Context
{
    public class MuseumContext : DbContext
    {
        public DbSet<Auditorium> Auditoriums { get; set; }
        public DbSet<Exhibit> Exhibits { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<ExhibitTag> ExhibitTags { get; set; }
        public DbSet<Entities.Museum> Museums { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }

        public MuseumContext(DbContextOptions options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /// <summary>
            /// Ticket -> User relation
            /// </summary>
            /// <returns></returns>
            modelBuilder.Entity<Ticket>()
                .HasOne(x => x.User)
                .WithMany(x => x.Tickets)
                .HasForeignKey(x => x.UserId)
                .IsRequired();

            /// <summary>
            /// User -> Ticket relation
            /// </summary>
            /// <returns></returns>
            modelBuilder.Entity<User>()
                .HasMany(x => x.Tickets)
                .WithOne(x => x.User)
                .IsRequired();


        }
    }
}
