using System;
using Test2113110015.Day2;
using Test2113110015.Day3;
using Test2113110015.Day5;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test2113110015
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //NavigationPage
            var page1 = new NavPage1();
            var np = new NavigationPage(page1);
            //var np = new NavigationPage(new NavPage1);
            var Page3 = new NavPage3();

            //TabbedPage
            var tp = new TabbedPage();
            tp.Children.Add(new TabPage1());
            tp.Children.Add(new TabPage2());
            tp.Children.Add(new TabPage3());

            //MainPage = new NavPage1();
            MainPage = np;
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
