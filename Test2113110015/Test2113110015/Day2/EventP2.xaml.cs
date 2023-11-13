using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace Test2113110015.Day2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventP2 : ContentPage
	{
		public EventP2 ()
		{
			InitializeComponent ();
			sendButton.Clicked += ButtonClickedDay2;
			addEntry.TextChanged += TextChange;
		}

        private void TextChange(object sender, TextChangedEventArgs e)
        {
            showLabel.Text = "Address is " + addEntry.Text;
        }

        private void ButtonClickedDay2(object sender, EventArgs e)
        {
            //showLabel.Text = showLabel.Text + fNameEntry.Text;
            showLabel.Text = "Hi, Sir " + fNameEntry.Text;
        }
    }
    
}