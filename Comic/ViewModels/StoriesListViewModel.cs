using System;
using System.Collections.Generic;
using System.ComponentModel;
using Comic.Models;

namespace Comic.ViewModels
{
    public class StoriesListViewModel : INotifyPropertyChanged
    {
        public List<Story> Stories { get; set; }

        public StoriesListViewModel()
        {
            Stories = new List<Story>
            {
                new Story { CoverImage = "icon.png", Id = 1, Name = "David vs Goliath", StoryUrl = "https://res.cloudinary.com/rumplestiltskin/image/upload/v1586899691/DAVID_AND_GOLIATH_wgccuf.pdf"},
                new Story { CoverImage = "icon.png", Id = 4, Name = "Godzilla", StoryUrl = "https://res.cloudinary.com/rumplestiltskin/image/upload/v1586832211/bakker-et-al2011IJER-TmLboundaries_sztexd.pdf"},
                new Story { CoverImage = "demo.jpg", Id = 2, Name = "Godzilla", StoryUrl = "https://res.cloudinary.com/rumplestiltskin/image/upload/v1586827719/Ogbara_Godstar_Web_Developer_Resume_2018_Recovered_pmqflr.pdf"},
                new Story { CoverImage = "demo.jpg", Id = 3, Name = "Godzilla", StoryUrl = "https://res.cloudinary.com/rumplestiltskin/image/upload/v1586827719/Ogbara_Godstar_Web_Developer_Resume_2018_Recovered_pmqflr.pdf"}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
