using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels.Fields;

namespace VBulletinThreadWriterGUI.ViewModels
{
    public class AdditionalSettingsFieldVM
    {
        private AdditionalSettingsSection AdditionalSettings { get; set; }
        public string Description { get => AdditionalSettings.Description; set => AdditionalSettings.Description = value; }
        public string Image { get => AdditionalSettings.Image != null ? AdditionalSettings.Image.LocalPath : ""; set => AdditionalSettings.Image = new Uri(value); }

        public AdditionalSettingsFieldVM()
        {
            //this.AdditionalSettings = new AdditionalSettingsSection(null, "");
        }
    }
}
