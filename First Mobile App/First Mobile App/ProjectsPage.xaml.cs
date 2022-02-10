using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace First_Mobile_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectsPage : ContentPage
    {
        public List<string> Projects { get; set; }
        public ProjectsPage()
        {
            InitializeComponent();
            Projects = new List<string>();
            this.BindingContext = this;
            FillList();
        }

        private async void lwProjects_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new ProjectPage(lwProjects.SelectedItem.ToString()));
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
        }

        private void FillList()
        {
            for(int i = 0; i < 20; i++)
            {
                Projects.Add($"Проект {i}");
            }
        }
    }
}