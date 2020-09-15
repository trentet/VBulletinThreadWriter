#nullable enable
using System;

namespace VBulletinThreadWriterGUI.Models.TrainingMethodModels.Fields
{
    public class WorldGridSection
    {
        public Uri? Image { get; set; }
        public string Description { get; set; }

        public WorldGridSection()
        {
            this.Image = null;
            this.Description = "";
        }

        public WorldGridSection(Uri image)
        {
            this.Image = image;
            this.Description = "";
        }

        public WorldGridSection(string description)
        {
            this.Image = null;
            this.Description = description;
        }

        public WorldGridSection(Uri image, string description)
        {
            this.Image = image;
            this.Description = description;
        }
    }
}
