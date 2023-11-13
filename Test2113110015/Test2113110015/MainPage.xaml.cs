using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Test2113110015
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void okButton_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World");
            await okButton.RotateTo(360, 100);
            await okButton.RotateTo(0, 1);

        }
    }
}
