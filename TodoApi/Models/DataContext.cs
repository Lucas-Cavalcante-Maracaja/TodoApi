using TodoApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Collect> Collects { get; set; }

        public DbSet<Area> Areas { get; set; }
        public DbSet<Equipment> Equipments { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Collect>()
                .HasOne(p => p.DemandObj)
                .WithMany(b => b.Collects);

            modelBuilder.Entity<Collect>()
               .HasOne(p => p.TargetObjectObj)
               .WithMany(b => b.Collects);

            modelBuilder.Entity<Equipment>()
               .HasOne(p => p.UserObj)
               .WithMany(b => b.Equipments)
               .HasForeignKey(p => p.IdUser);

            modelBuilder.Entity<Area>()
               .HasOne(p => p.DescriptionObj)
               .WithOne(b => b.AreaObj)
               .HasForeignKey<Area>(p => p.IdDescription);

            modelBuilder.Entity<BookAuthor>()
            .HasKey(x => new { x.BookId, x.AuthorId });

            modelBuilder.Entity<BookAuthor>()
                .HasOne(pt => pt.Book)
                .WithMany(p => p.AuthorsLink)
                .HasForeignKey(pt => pt.BookId);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(pt => pt.Author)
                .WithMany(t => t.BooksLink)
                .HasForeignKey(pt => pt.AuthorId);
        }

    }
}
