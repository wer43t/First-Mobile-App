using System;
using Xamarin.Forms;

namespace First_Mobile_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async void btnRegistration_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageRegistration());
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProjectsPage());
        }
    }
}
