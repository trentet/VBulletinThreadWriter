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

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.Fields{
    /// <summary>
    /// Interaction logic for MachineDataField.xaml
    /// </summary>
    public partial class MachineDataField : UserControl
    {
        public MachineDataField()
        {
            InitializeComponent();
        }
    }

    public class MachineDataFieldVM
    {
        public ScriptExampleModel ScriptExample { get; set; }
        public string Description
        {
            get => ScriptExample.MachineDataSection.Description;
            set => ScriptExample.MachineDataSection.Description = value;
        }

        public string Image
        {
            get => ScriptExample.MachineDataSection.Image != null ? ScriptExample.MachineDataSection.Image.LocalPath : "";
            set => ScriptExample.MachineDataSection.Image = new Uri(value);
        }

        public MachineDataFieldVM(ScriptExampleModel scriptExample)
        {
            this.ScriptExample = scriptExample;
        }
    }
}
