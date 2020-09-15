#nullable enable
using System;

namespace VBulletinThreadWriterGUI
{
    public class MachineDataSection
    {
        public Uri? Image { get; set; }
        public string Description { get; set; }

        public MachineDataSection()
        {
            this.Image = null;
            this.Description = "";
        }

        public MachineDataSection(Uri image)
        {
            this.Image = image;
            this.Description = "";
        }

        public MachineDataSection(string description)
        {
            this.Image = null;
            this.Description = description;
        }

        public MachineDataSection(Uri image, string description)
        {
            this.Image = image;
            this.Description = description;
        }
    }
}
