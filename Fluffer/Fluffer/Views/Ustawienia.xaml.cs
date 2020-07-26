using Fluffer.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluffer.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fluffer.Droid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ustawienia : ContentPage
    {
        public Ustawienia()
        {
            InitializeComponent();
            login.Text = Database.LoggedUser.Login;
            haslo.Text = Database.LoggedUser.Password;
            zdj.Source = Database.LoggedUser.PhotoStr;
        }

        private void PowrotButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profil());
          
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;

            Stream stream = await DependencyService.Get<IPhotoPickerService>().GetImageStreamAsync();
            if (stream != null)
            {
                image.Source = ImageSource.FromStream(() => stream);
            }

    (sender as Button).IsEnabled = true;
        }
    }
}