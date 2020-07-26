using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Fluffer.Droid;
using Fluffer.Droid.Views;
using Fluffer.Models;
using System.IO;

namespace Fluffer
{
    public partial class App : Application
    {
        static Database database;

        public static Database Database
        {
            get
            {
               if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "flufferAnimalsF6.db3"));
              }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Startowa());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
