using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Models
{
    public class NoteHandler
    {
        public List<Note> Notes { get; set; }
        public String NoteName { get; set; }

        public async Task NoteHandler1(string name)
        {
            NoteService reff = new NoteService();
            Notes = await reff.GetNotes();

            return;
        }

        public void Add(Note note)
        {
            if (Notes != null)
            {
                if (!Notes.Contains(note))
                {
                    Notes.Add(note);
                    NoteService.Write(note);
                }
            }
        }

        public void Delete(Note note)
        {
            if (Notes.Contains(note))
            {
                Notes.Remove(note);
                NoteService.Delete(note);
            }
        }

        public void Update(Note note)
        {
            NoteService.Write(note);
        }
    }
}
