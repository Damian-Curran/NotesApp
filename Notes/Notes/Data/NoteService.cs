using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Data
{
    public class Note
    {
        public String NoteName { get; set; }
        public String NoteDes { get; set; }
    }

    public class NoteService
    {
        public static String Name = "Fake Data Service.";

        public static List<Note> GetNotes()
        {
            return new List<Note>()
                {
                    new Note() { NoteName="Shopping", NoteDes="Food, Drinks" },
                    new Note() { NoteName="College", NoteDes="Prepare Presentation" },
                    new Note() { NoteName="Birthday", NoteDes="January 1st 2000" }
                };
        }

        public static void Write(Note note)
        {
            Debug.WriteLine("INSERT person with name " + note.NoteName);
        }

        public static void Delete(Note note)
        {
            Debug.WriteLine("DELETE person with name " + note.NoteName);
        }
    }
}