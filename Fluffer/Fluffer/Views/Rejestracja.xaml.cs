using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluffer.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fluffer.Droid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Rejestracja : ContentPage
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        private async void UtworzButton_Clicked(object sender, EventArgs e)
        {
            if(Haslo_nowy.Text == Powtorz_haslo.Text)
            {
                var user = new User
                {
                    Login = Login_nowy.Text,
                    Password = Haslo_nowy.Text,
                    PhotoStr = @"https://i.ibb.co/92827tf/blank.png"
                };
                await App.Database.SaveUserAsync(user);
                Database.LoggedUser = user;
               // await Navigation.PushAsync(new Ustawienia());
               await Navigation.PushAsync(new Profil());
            }
            else
            {
                blad.IsVisible = true;
            }


        }
    }
}