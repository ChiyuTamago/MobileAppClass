using System;
using Test2113110015.Day2;
using Test2113110015.Day3;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test2113110015
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DayThreeTest();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
