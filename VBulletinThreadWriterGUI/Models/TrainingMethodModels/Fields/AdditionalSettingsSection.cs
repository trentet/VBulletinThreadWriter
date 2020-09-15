#nullable enable

using System;

namespace VBulletinThreadWriterGUI.Models.TrainingMethodModels.Fields
{
    public class AdditionalSettingsSection
    {
        public Uri? Image { get; set; }
        public string Description { get; set; }

        public AdditionalSettingsSection()
        {
            this.Image = null;
            this.Description = "";
        }

        public AdditionalSettingsSection(Uri image)
        {
            this.Image = image;
            this.Description = "";
        }

        public AdditionalSettingsSection(string description)
        {
            this.Image = null;
            this.Description = description;
        }

        public AdditionalSettingsSection(Uri image, string description)
        {
            this.Image = image;
            this.Description = description;
        }
    }
}
