using System;
using System.Collections.Generic;
using Comic.Models;
using Comic.ViewModels;
using Xamarin.Forms;

namespace Comic.Views
{
    public partial class StoryPage : ContentPage
    {
        public PdfViewerViewModel pdfViewerViewModel { get; set; }

        public StoryPage()
        {
            InitializeComponent();

            pdfViewerViewModel = new PdfViewerViewModel();
            pdfViewerControl.InputFileStream = pdfViewerViewModel.PdfDocumentStream;

            //this.BindingContext = pdfViewerViewModel;
        }
    }
}
