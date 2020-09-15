#nullable enable
using System;

namespace VBulletinThreadWriterGUI.Models.TrainingMethodModels
{
    public class InterfaceItem
    {
        public Uri? Image { get; set; }
        public string Description { get; set; }

        public InterfaceItem()
        {
            this.Image = null;
            this.Description = "";
        }

        public InterfaceItem(Uri image)
        {
            this.Image = image;
            this.Description = "";
        }

        public InterfaceItem(string description)
        {
            this.Image = null;
            this.Description = description;
        }

        public InterfaceItem(Uri image, string description)
        {
            this.Image = image;
            this.Description = description;
        }
    }
}
