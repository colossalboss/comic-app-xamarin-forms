using System;
using Comic.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Comic
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StoriesListPage());
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
