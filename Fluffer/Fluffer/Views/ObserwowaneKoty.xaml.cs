using Fluffer.Models;
using Fluffer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fluffer.Droid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObserwowaneKoty : ContentPage
    {
        ViewCell lastCell;
        public ObserwowaneKoty()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
        base.OnAppearing();
        List<Animal> animals = await App.Database.GetAnimalAsync();
        List<UserAnimal> uA = await App.Database.GetUserAnimalAsync();
        List<UserAnimal> hh = uA.Where(x => x.UserId == Database.LoggedUser.UserId).ToList();
       
            List<Animal> animalLike = new List<Animal>();
            foreach (var item in uA)
            {
                foreach (var i in animals)
                {
                    if (item.UserId == Database.LoggedUser.UserId)
                    {
                        if (item.AnimalId == i.AnimalId)
                        {
                            if (!animalLike.Contains(i))
                                animalLike.Add(i);
                            
                        }
                    }
                }
            }
            animallist.ItemsSource = animalLike;
        }
        
        private void PowrotButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profil());
        }

        private void animallist_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            var mydetails = e.Item as Animal;
            Database.obecneId = mydetails.AnimalId;
            Navigation.PushAsync(new Description(mydetails.Name, mydetails.Description, mydetails.FirstPhoto,mydetails.Age));
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            if (lastCell != null)
                lastCell.View.BackgroundColor = Color.Transparent;
            var viewCell = (ViewCell)sender;
            if (viewCell.View != null)
            {
                viewCell.View.BackgroundColor = Color.HotPink;
                lastCell = viewCell;
            }
        }
    }
}