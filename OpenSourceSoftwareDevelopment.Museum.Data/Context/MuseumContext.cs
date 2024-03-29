﻿using Microsoft.EntityFrameworkCore;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Context
{
    public class MuseumContext : DbContext
    {
        public DbSet<AuditoriumEntity> Auditoriums { get; set; }
        public DbSet<ExhibitEntity> Exhibits { get; set; }
        public DbSet<ExhibitionEntity> Exhibitions { get; set; }
        public DbSet<MuseumEntity> Museums { get; set; }
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

            /// <summary>
            /// Ticket -> Exhibition relation
            /// </summary>
            /// <returns></returns>
            modelBuilder.Entity<TicketEntity>()
                .HasOne(x => x.Exhibition)
                .WithMany(x => x.Tickets)
                .HasForeignKey(x => x.ExhibitionId)
                .IsRequired();

            /// <summary>
            /// Exhibition -> Ticket relation
            /// </summary>
            /// <returns></returns>
            modelBuilder.Entity<ExhibitionEntity>()
                .HasMany(x => x.Tickets)
                .WithOne(x => x.Exhibition)
                .IsRequired();

            /// <summary>
            /// Exhibit -> Exhibition relation
            /// </summary>
            /// <returns></returns>
            modelBuilder.Entity<ExhibitEntity>()
                .HasOne(x => x.Exhibition)
                .WithMany(x => x.Exhibits)
                .HasForeignKey(x => x.ExhibitionId)
                .IsRequired();

            /// <summary>
            /// Exhibition -> Exhibit relation
            /// </summary>
            /// <returns></returns>
            modelBuilder.Entity<ExhibitionEntity>()
                .HasMany(x => x.Exhibits)
                .WithOne(x => x.Exhibition)
                .IsRequired();

            /// <summary>
            /// Exhibition -> Auditorium relation
            /// </summary>
            /// <returns></returns>
            modelBuilder.Entity<ExhibitionEntity>()
                .HasOne(x => x.Auditorium)
                .WithMany(x => x.Exhibitions)
                .HasForeignKey(x => x.AuditoriumId)
                .IsRequired();

            /// <summary>
            /// Auditorium -> Exhibition relation
            /// </summary>
            /// <returns></returns>
            modelBuilder.Entity<AuditoriumEntity>()
                .HasMany(x => x.Exhibitions)
                .WithOne(x => x.Auditorium)
                .IsRequired();

            /// <summary>
            /// Auditorium -> Museum relation
            /// </summary>
            /// <returns></returns>
            modelBuilder.Entity<AuditoriumEntity>()
                .HasOne(x => x.Museum)
                .WithMany(x => x.Auditoriums)
                .HasForeignKey(x => x.MuseumId)
                .IsRequired();

            /// <summary>
            /// Museum -> Auditorium relation
            /// </summary>
            /// <returns></returns>
            modelBuilder.Entity<MuseumEntity>()
                .HasMany(x => x.Auditoriums)
                .WithOne(x => x.Museum)
                .IsRequired();
        }
    }
}
