using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Assessment6b.Models
{
    public partial class JellybeanDbContext : DbContext
    {
        public JellybeanDbContext()
        {
        }

        public JellybeanDbContext(DbContextOptions<JellybeanDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<JellyBean> JellyBean { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-F30FORNB\\SQLEXPRESS;Database=JellybeanDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JellyBean>(entity =>
            {
                entity.Property(e => e.Style).HasMaxLength(40);
            });
        }
    }
}
