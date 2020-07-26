using Fluffer.Droid;
using Fluffer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fluffer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Description : ContentPage
    {
        public Description(string Name, string Description, string Url, string Age)
        {
            InitializeComponent();
            AnimalName.Text = Name;
            AnimalDescription.Text = Description;
            // Photo.Source = Url;
           // AgeA.Text = Age;

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            List<Photo> photos = await App.Database.GetPhotoAsync();
            List<Photo> photoPomocne = new List<Photo>();
            List<Animal> animals = await App.Database.GetAnimalAsync();
            //foreach (var item in photos)
            //{
            //    foreach (var i in animals)
            //    {
            //        if (item.AnimalId == Database.obecneId)
            //        {
            //            if ((i.AnimalId == item.AnimalId))
            //            {
            //                if(!photos.Contains(item)) 
            //                {
            //                    if (i.FirstPhoto!=item.Url)
            //                    {
            //                        Photo p = new Photo
            //                        {
            //                            AnimalId = Database.obecneId,
            //                            Url = i.FirstPhoto
            //                        };
            //                        if (!photos.Contains(p))
            //                        {
            //                            await App.Database.SavePhotoAsync(p);
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            foreach (var item in photos)
            {
                if (item.AnimalId == Database.obecneId)
                {
                    photoPomocne.Add(item);
                }
            }
            karuzela.ItemsSource = photoPomocne;
        }
        private void back_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StronaGlowna());
        }
    }
}