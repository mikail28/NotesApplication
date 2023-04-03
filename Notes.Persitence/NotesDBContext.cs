using Microsoft.EntityFrameworkCore;
using Notes.Aplication.interfaces;
using Notes.Domain;
using Notes.Persitence.EntityTypeConfiguration;

namespace Notes.Persitence
{
    internal class NotesDBContext : DbContext, INotesDBContext
    {
        public DbSet<Note> Notes { get; set; }

        public NotesDBContext(DbContextOptions<NotesDBContext> dbContextOptions):base(dbContextOptions)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NotesConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
