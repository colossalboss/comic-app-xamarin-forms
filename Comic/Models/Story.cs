using System;
namespace Comic.Models
{
    public class Story
    {
        public Story()
        {
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string CoverImage { get; set; }

        public string StoryUrl { get; set; }

    }
}
