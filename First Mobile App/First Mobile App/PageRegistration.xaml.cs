
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace First_Mobile_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageRegistration : ContentPage
    {
        public PageRegistration()
        {
            InitializeComponent();
        }

        private async void btnRegistration_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}