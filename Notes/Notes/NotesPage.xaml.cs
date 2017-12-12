using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Notes
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NotesPage : Page
    {
        public NotesPage()
        {
            this.InitializeComponent();
            NoteHandler = new NoteHandlerViewModel();
            NoteHandler.NoteHandlerViewModel1("College");
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var hello = (NoteViewModel)e.ClickedItem;

            stack1.Visibility = Visibility.Collapsed;
            stack2.Visibility = Visibility.Visible;
        }

        public NoteHandlerViewModel NoteHandler { get; set; }
    }
}
