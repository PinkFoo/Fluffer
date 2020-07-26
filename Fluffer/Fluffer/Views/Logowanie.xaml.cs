using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using Fluffer.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Fluffer.Models;

namespace Fluffer.Droid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Logowanie : ContentPage
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private async void zalogujButton_Clicked(object sender, EventArgs e)
        {

           List<User> users = await App.Database.GetUserAsync();
            var userLogged = users.Where(x => x.Login == login.Text && x.Password == haslo.Text).FirstOrDefault();
            if(userLogged != null)
            {
                Database.LoggedUser = userLogged;
               //  await Navigation.PushAsync(new StronaGlowna());
                await Navigation.PushAsync(new Profil());
            }
            else
            {
                blad.IsVisible = true;
            }


                   
        }


    }
}