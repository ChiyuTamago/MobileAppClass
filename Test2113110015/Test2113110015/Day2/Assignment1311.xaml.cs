using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test2113110015.Day2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Assignment1311 : ContentPage
	{
		public Assignment1311 ()
		{
			InitializeComponent ();
            sendButton.Clicked += SendButton_Clicked;
		}

        private void SendButton_Clicked(object sender, EventArgs e)
        {
			loginNameResult.Text = firstName.Text + " " + lastName.Text;
        }
    }
}