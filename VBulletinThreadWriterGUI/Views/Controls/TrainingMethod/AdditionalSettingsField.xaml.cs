using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels.Fields;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod
{
    /// <summary>
    /// Interaction logic for AdditionalSettingsField.xaml
    /// </summary>
    public partial class AdditionalSettingsField : UserControl
    {
        public AdditionalSettingsField()
        {
            InitializeComponent();
        }
    }

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
