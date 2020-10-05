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
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels.Fields;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.Fields
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
        public ScriptExampleModel ScriptExample { get; set; }
        public string Description 
        { 
            get => ScriptExample.AdditionalSettingsSection.Description; 
            set => ScriptExample.AdditionalSettingsSection.Description = value; 
        }
        public string Image 
        { 
            get => ScriptExample.AdditionalSettingsSection.Image != null ? ScriptExample.AdditionalSettingsSection.Image.LocalPath : ""; 
            set => ScriptExample.AdditionalSettingsSection.Image = new Uri(value); }

        public AdditionalSettingsFieldVM(ScriptExampleModel scriptExample)
        {
            this.ScriptExample = scriptExample;
        }
    }
}
