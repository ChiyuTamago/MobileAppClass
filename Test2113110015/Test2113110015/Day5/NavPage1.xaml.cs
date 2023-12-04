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
	public partial class NavPage1 : ContentPage
	{
		public NavPage1 ()
		{
			InitializeComponent ();

            OpenP2.Clicked += OpenP2_Clicked;
            OpenP3.Clicked += OpenP3_Clicked;
            OpenTab.Clicked += OpenTab_Clicked;
		}

        private async void OpenTab_Clicked(object sender, EventArgs e)
        {
            //TabbedPage
            var tp = new TabbedPage();
            tp.Children.Add(new TabPage1());
            tp.Children.Add(new TabPage2());
            tp.Children.Add(new TabPage3());
            await Navigation.PushAsync(tp);
        }

        private async void OpenP3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavPage3());
        }

        private async void OpenP2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavPage2 ());
        }
    }
}