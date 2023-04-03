using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Persitence
{
    internal class DbInitializer
    {
        public static void Initialize(NotesDBContext notesDBContext)
        {
            notesDBContext.Database.EnsureCreated();
        }
    }
}
