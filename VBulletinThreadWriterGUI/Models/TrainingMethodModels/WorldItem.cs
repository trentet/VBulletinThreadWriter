#nullable enable
using System;

namespace VBulletinThreadWriterGUI.Models.TrainingMethodModels
{
    public class WorldItem
    {
        public Uri? Image { get; set; }
        public string Description { get; set; }

        public WorldItem()
        {
            this.Image = null;
            this.Description = "";
        }

        public WorldItem(Uri image)
        {
            this.Image = image;
            this.Description = "";
        }

        public WorldItem(string description)
        {
            this.Image = null;
            this.Description = description;
        }

        public WorldItem(Uri image, string description)
        {
            this.Image = image;
            this.Description = description;
        }
    }
}
