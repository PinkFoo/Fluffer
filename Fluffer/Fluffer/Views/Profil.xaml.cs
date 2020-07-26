using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluffer.Models;
using Fluffer.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Fluffer.Droid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profil : ContentPage
    {
       
        public Profil()
        {
            InitializeComponent();
            login.Text = Database.LoggedUser.Login;
            zdj.Source = Database.LoggedUser.PhotoStr;

        }

        async void UstawieniaButton_Clicked(object sender, EventArgs e)
        {
            Database.LoggedUser.PhotoStr = photo.Text;
            await App.Database.UpdateUserAsync(Database.LoggedUser);
            photo.Text = "";

        }

        private void MojeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ObserwowaneKoty());
        }

        async void PhotoPbutton_Clicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;

            Stream stream = await DependencyService.Get<IPhotoPickerService>().GetImageStreamAsync();
            if (stream != null)
            {

                zdj2.Source = ImageSource.FromStream(() => stream);
           
               
            }

            (sender as Button).IsEnabled = true;
        }

        private void likeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StronaGlowna());
        }
    }
}