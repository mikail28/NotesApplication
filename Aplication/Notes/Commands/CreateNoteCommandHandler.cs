using MediatR;
using Notes.Aplication.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Aplication.Notes.Commands
{
    internal class CreateNoteCommandHandler : IRequestHandler<CreateNoteCommand>
    {
        private readonly INotesDBContext notesdDbContext;
        public Task Handle(CreateNoteCommand request, CancellationToken cancellationToken)
        {

        }
    }
}
