using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test2113110015.Day3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DayThreeTest : ContentPage
	{
		public DayThreeTest ()
		{
			InitializeComponent ();

            sauceNaoSlider.ValueChanged += sauceNaoSlider_Change;
            Stepper.ValueChanged += StepperChanged;
            genderPicker.SelectedIndexChanged += genderPickerChanged;
        }

        private void genderPickerChanged(object sender, EventArgs e)
        {
            picker.Text = genderPicker.SelectedItem.ToString();
        }

        private void StepperChanged(object sender, ValueChangedEventArgs e)
        {
            Kay.Text = e.NewValue.ToString();
        }

        private void sauceNaoSlider_Change(object sender, ValueChangedEventArgs e)
        {
            Mao.Text = e.NewValue.ToString("N0");

        }
    }
}