using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Context
{
    public class MuseumContext : DbContext
    {
        public DbSet<AuditoriumEntity> Auditoriums { get; set; }
        public DbSet<ExhibitEntity> Exhibits { get; set; }
        public DbSet<ExhibitionEntity> Exhibitions { get; set; }
        public DbSet<ExhibitTagEntity> ExhibitTags { get; set; }
        public DbSet<Entities.MuseumEntity> Museums { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<TicketEntity> Tickets { get; set; }
        public DbSet<UserEntity> Users { get; set; }

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
            modelBuilder.Entity<TicketEntity>()
                .HasOne(x => x.User)
                .WithMany(x => x.Tickets)
                .HasForeignKey(x => x.UserId)
                .IsRequired();

            /// <summary>
            /// User -> Ticket relation
            /// </summary>
            /// <returns></returns>
            modelBuilder.Entity<UserEntity>()
                .HasMany(x => x.Tickets)
                .WithOne(x => x.User)
                .IsRequired();


        }
    }
}
