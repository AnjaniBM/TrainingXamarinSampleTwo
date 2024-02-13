using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TrainingXamarinSampleTwo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();// Constructor for the main page

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           label1.Text = fName.Text + "\t"+ lName.Text;
        }
    }
}
