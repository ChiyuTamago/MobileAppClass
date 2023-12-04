using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2113110015.Day2;
using Test2113110015.Day3;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test2113110015.Day5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavPage2 : ContentPage
	{
		public NavPage2 ()
		{
			InitializeComponent ();
            //TabbedPage
            justTab.Clicked += JustTab_Clicked;
            


        }

        private async void JustTab_Clicked(object sender, EventArgs e)
        {
            var tp = new TabbedPage();
            tp.Children.Add(new DayThreeTest());
            tp.Children.Add(new Assignment1311());
            tp.Children.Add(new EventP2());
            await Navigation.PushAsync(tp);
        }
    }
}