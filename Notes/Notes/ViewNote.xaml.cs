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
    public sealed partial class ViewNote : Page
    {
        public ViewNote()
        {
            this.InitializeComponent();
            NoteHandler = new NoteHandlerViewModel();
            NoteHandler.NoteHandlerViewModel1("College");
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var hello = e.Parameter;
            var me = (NoteViewModel)hello;
            string  nn = me.NoteName;
            string  nd = me.NoteDes;

            txt1.Text = nn;
            txt2.Text = nd;

            MessageDialog msgDialog = new MessageDialog(nn, nd);
            msgDialog.ShowAsync();

            //string nn = hello.NoteName;
            //string nd = hello.NoteDes;
        }

        public NoteHandlerViewModel NoteHandler { get; set; }
    }
}
