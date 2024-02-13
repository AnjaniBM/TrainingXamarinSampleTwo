using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingXamarinSampleTwo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PostPage : ContentPage
	{
		public PostPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Post

            label1.Text = fName.Text + " " + lName.Text + " " + comments.Text;

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            //Clear
            fName.Text = null;
            lName.Text = null;
            comments.Text = null;
        }
    }
}