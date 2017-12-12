using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Models;

namespace ViewModels
{
    public class NoteHandlerViewModel : NotificationBase
    {
        NoteHandler notehandler;

        public async void NoteHandlerViewModel1(String name)
        {
            notehandler = new NoteHandler();
            _SelectedIndex = -1;
            try
            {
                await notehandler.NoteHandler1(name);
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            // Load the database
            if (notehandler.Notes != null)
            {
                foreach (var note in notehandler.Notes)
                {
                    var newNote = new NoteViewModel(note);
                    newNote.PropertyChanged += Notes_OnNotifyPropertyChanged;
                    _Notes.Add(newNote);
                }
            }
        }

        ObservableCollection<NoteViewModel> _Notes
           = new ObservableCollection<NoteViewModel>();
        public ObservableCollection<NoteViewModel> Notes
        {
            get { return _Notes; }
            set { SetProperty(ref _Notes, value); }
        }

        String _Name;
        public String Name
        {
            get { return notehandler.NoteName; }
        }

        int _SelectedIndex;
        public int SelectedIndex
        {
            get { return _SelectedIndex; }
            set
            {
                if (SetProperty(ref _SelectedIndex, value))
                { RaisePropertyChanged(nameof(SelectedNote)); }
            }
        }

        public NoteViewModel SelectedNote
        {
            get { return (_SelectedIndex >= 0) ? _Notes[_SelectedIndex] : null; }
        }

        public void Add()
        {
            var note = new NoteViewModel();
            note.PropertyChanged += Notes_OnNotifyPropertyChanged;
            Notes.Add(note);
            notehandler.Add(note);
            SelectedIndex = Notes.IndexOf(note);
        }

        public void Delete()
        {
            if (SelectedIndex != -1)
            {
                var note = Notes[SelectedIndex];
                Notes.RemoveAt(SelectedIndex);
                notehandler.Delete(note);
            }
        }

        void Notes_OnNotifyPropertyChanged(Object sender, PropertyChangedEventArgs e)
        {
            notehandler.Update((NoteViewModel)sender);
        }
    }
}
