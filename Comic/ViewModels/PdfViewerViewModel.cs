using System;
using System.ComponentModel;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Comic.Models;

namespace Comic.ViewModels
{
    public class PdfViewerViewModel : INotifyPropertyChanged
    {
        private Stream pdfDocumentStream;

        public Story Story { get; set; }

        public string URL { get; set; }

        public PdfViewerViewModel()
        {
            this.URL = "https://res.cloudinary.com/rumplestiltskin/image/upload/v1586827719/Ogbara_Godstar_Web_Developer_Resume_2018_Recovered_pmqflr.pdf";
            SetStreamAsync();

        }

        public PdfViewerViewModel(string url)
        {
            this.URL = url;
            SetStreamAsync();
           
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public Stream PdfDocumentStream
        {
            get { return pdfDocumentStream; }
            set
            {
                //Check the value whether it is the same as the currently loaded stream
                if (value != pdfDocumentStream)
                {
                    pdfDocumentStream = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("PdfDocumentStream"));
                }
            }
        }

        private async Task<Stream> DownloadPdfStream(string URL)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(URL);
            //Check whether redirection is needed
            if ((int)response.StatusCode == 302)
            {
                //The URL to redirect is in the header location of the response message
                HttpResponseMessage redirectedResponse = await httpClient.GetAsync(response.Headers.Location.AbsoluteUri);
                return await redirectedResponse.Content.ReadAsStreamAsync();
            }
            return await response.Content.ReadAsStreamAsync();
        }

        private async void SetStreamAsync()
        {

            PdfDocumentStream = await DownloadPdfStream(URL);

        }
    }
}
