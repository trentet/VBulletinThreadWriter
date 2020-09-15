#nullable enable
using System;

namespace VBulletinThreadWriterGUI
{
    public class MapSection
    {
        public Uri? Image { get; set; }
        public string Description { get; set; }

        public MapSection()
        {
            this.Image = null;
            this.Description = "";
        }

        public MapSection(Uri image)
        {
            this.Image = image;
            this.Description = "";
        }

        public MapSection(string description)
        {
            this.Image = null;
            this.Description = description;
        }

        public MapSection(Uri image, string description)
        {
            this.Image = image;
            this.Description = description;
        }
    }
}
