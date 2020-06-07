using System;
using System.Collections.Generic;
using Comic.Models;
using Comic.ViewModels;
using Xamarin.Forms;

namespace Comic.Views
{
    public partial class ReadStoryPage : ContentPage
    {
        public ReadStoryPage(Story story)
        {
            InitializeComponent();

            var x = new PdfViewerViewModel(story.StoryUrl);

            this.BindingContext = x;
        }
    }
}
