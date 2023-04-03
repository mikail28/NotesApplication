using Microsoft.EntityFrameworkCore;
using Notes.Domain;

namespace Notes.Aplication.interfaces
{
    public interface INotesDBContext
    {
        DbSet<Note> Notes { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
