using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Fluffer.Droid.Views;


namespace Fluffer.Droid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Startowa : ContentPage
    {
        public Startowa()
        {
            InitializeComponent();
        }

        private void ZalogujButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Logowanie());
        }

        private void StworzButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Rejestracja());
        }
    }
    
}