using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluffer.Droid.Views;
using Fluffer.Models;
using Fluffer.Services;
using Fluffer.Views;
using MLToolkit.Forms.SwipeCardView;
using MLToolkit.Forms.SwipeCardView.Core;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Fluffer.Droid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StronaGlowna : ContentPage
    {
        public int iterator = 0;
        public StronaGlowna()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            List<Animal> an = await App.Database.GetAnimalAsync();
            an.OrderBy(x => x.AnimalId);
            // SwipeView1.ItemsSource = await App.Database.GetAnimalAsync();
            SwipeView1.ItemsSource = an;
            Database.obecneId = 0;
        }

        private void ProfilButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profil());
        }

        private void WiadomosciBUtton_Clicked(object sender, EventArgs e)
        {
            
        }

        private void LapaButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profil());
        }

        private async void nopeButton_Clicked(object sender, EventArgs e)
        {
           await SwipeView1.InvokeSwipe((MLToolkit.Forms.SwipeCardView.Core.SwipeCardDirection)MLToolkit.Forms.SwipeCardView.Core.SwipeCardDirection.Left);
            iterator++;
        }

        private async void likeButton_Clicked(object sender, EventArgs e)
        {
           await SwipeView1.InvokeSwipe((MLToolkit.Forms.SwipeCardView.Core.SwipeCardDirection)MLToolkit.Forms.SwipeCardView.Core.SwipeCardDirection.Right);
            SwipeView1.SupportedSwipeDirections = SwipeCardDirection.Right;
            var animal = await App.Database.GetAnimalAsync();
           var a = animal.ElementAt(iterator);
            UserAnimal ua = new UserAnimal
            {
                UserId = Database.LoggedUser.UserId,
                AnimalId = a.AnimalId
            };
            await App.Database.SaveUserAnimalAsync(ua);


            iterator++;
        }

        private void profilBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profil());
        }

        private void kontaktBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Kontakt());
        }

        private async void SwipeView1_Swiped(object sender, SwipedCardEventArgs e)
        {
            if(e.Direction.ToString()=="Right")
            {
                var animal = await App.Database.GetAnimalAsync();
                var a = animal.ElementAt(iterator);
                UserAnimal ua = new UserAnimal
                {
                    UserId = Database.LoggedUser.UserId,
                    AnimalId = a.AnimalId
                };
                await App.Database.SaveUserAnimalAsync(ua);


               // iterator++;
            }

            iterator++;
        }
        }


        //Próbny kod na dodawanie do bazy użytkownika + url zdjęcia
        //async void AddToDatabase_Clicked(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrWhiteSpace(loginEntry.Text) && !string.IsNullOrWhiteSpace(passwordEntry.Text) && !string.IsNullOrWhiteSpace(urlEntry.Text))
        //    {
        //        await App.Database.SaveUserAsync(new User
        //        {
        //            Login = loginEntry.Text,
        //            Password = passwordEntry.Text,
        //            PhotoStr = urlEntry.Text
        //        });

        //        loginEntry.Text = passwordEntry.Text = urlEntry.Text = string.Empty;
        //        listView.ItemsSource = await App.Database.GetUserAsync();
        //    }
        //}
    }
