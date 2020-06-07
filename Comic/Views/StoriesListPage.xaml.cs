using System;
using System.Collections.Generic;
using Comic.Models;
using Xamarin.Forms;

namespace Comic.Views
{
    public partial class StoriesListPage : ContentPage
    {
        public StoriesListPage()
        {
            InitializeComponent();
        }

        public void StoriesList_Tapped(object sender, ItemTappedEventArgs tappedEventArgs)
        {
            var story = tappedEventArgs.Item as Story;

            Navigation.PushAsync(new ReadStoryPage(story));
        }
    }
}
