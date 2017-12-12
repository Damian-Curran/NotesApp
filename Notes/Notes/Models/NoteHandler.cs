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

        public void Add(Note person)
        {
            if (!Notes.Contains(person))
            {
                Notes.Add(person);
                NoteService.Write(person);
            }
        }

        public void Delete(Note person)
        {
            if (Notes.Contains(person))
            {
                Notes.Remove(person);
                NoteService.Delete(person);
            }
        }

        public void Update(Note person)
        {
            NoteService.Write(person);
        }
    }
}
