using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;
using Notes;

namespace Data
{
    public class Note
    {
        public String id { get; set; }
        public String NoteName { get; set; }
        public String NoteDes { get; set; }
    }

    public class NoteService
    {
        private MobileServiceCollection<Note, Note> _notes;
        public MobileServiceCollection<Note, Note> notes
        {
            get
            {
                return _notes;
            }
            set
            {
                _notes = value;
            }
        }

        public async Task<List<Note>> GetNotes()
        {
            //Debug.WriteLine("INSERT person with name " + note.NoteName);
            Note obj = new Note();

            IMobileServiceTable<Note> userTableObj = App.MobileService.GetTable<Note>();
            
            //userTableObj.ReadAsync(note);

            notes = await userTableObj
               .ToCollectionAsync();

            //var message = string.Join(Environment.NewLine, notes);
            //
            //var something = notes[0].NoteName;
            //
            //MessageDialog msgDialog = new MessageDialog(message);
            //await msgDialog.ShowAsync();

            List<Note> noteList = new List<Note>();

            foreach(var n in notes)
            {
                noteList.Add(new Note() {id = n.id, NoteName = n.NoteName, NoteDes = n.NoteDes });
            }

            return await Task.FromResult(noteList);
        }

        public static async void Write(Note note)
        {
            //Debug.WriteLine("INSERT person with name " + note.NoteName);
            Note obj = new Note();
            obj.NoteName = note.NoteName;
            obj.NoteDes = note.NoteDes;
            obj.id = note.NoteName;
            
            var dupCount = 0;

            NoteService data = new NoteService();
            List<Note> listt = await data.GetNotes();

            IMobileServiceTable<Note> userTableObj = App.MobileService.GetTable<Note>();
            if (obj.NoteName != null && obj.NoteDes != null)
            {
                if (obj.NoteDes != "" && obj.NoteName != "")
                {
                    foreach (var n in listt)
                    {
                        if(note.NoteName == n.NoteName && note.NoteDes != n.NoteDes)
                        {
                            dupCount += 1;
                        }
                        
                    }

                    if(dupCount == 1)
                    {
                        await userTableObj.UpdateAsync(obj);
                        MessageDialog msgDialog = new MessageDialog("Data Updated!!!");
                        await msgDialog.ShowAsync();
                    }

                    if (dupCount == 0)
                    {
                        try
                        {
                            await userTableObj.InsertAsync(obj);
                            MessageDialog msgDialog = new MessageDialog("Data Inserted!!!");
                            await msgDialog.ShowAsync();
                        }

                        catch (Exception)
                        {
                            MessageDialog msgDialog = new MessageDialog("Use a unique Note Name");
                            await msgDialog.ShowAsync();
                        }
                    }
                }
            }
        }

        public static async void Delete(Note note)
        {
            Note obj = new Note();
            obj.NoteName = note.NoteName;
            obj.NoteDes = note.NoteDes;
            obj.id = note.NoteName;

            IMobileServiceTable<Note> userTableObj = App.MobileService.GetTable<Note>();

            await userTableObj.DeleteAsync(obj);
            MessageDialog msgDialog = new MessageDialog("Data Deleted!!!");
            await msgDialog.ShowAsync();
        }
    }
}
