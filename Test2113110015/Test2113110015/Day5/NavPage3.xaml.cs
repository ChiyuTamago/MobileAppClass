using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test2113110015.Day5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavPage3 : ContentPage
	{
		public NavPage3 ()
		{
			InitializeComponent ();

            close.Clicked += Close_Clicked;
		}

        private async void Close_Clicked(object sender, EventArgs e)
        {
			await Navigation.PopModalAsync();
        }
    }
}