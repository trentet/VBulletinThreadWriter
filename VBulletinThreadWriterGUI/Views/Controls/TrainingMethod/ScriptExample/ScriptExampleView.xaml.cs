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
using VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.Fields;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample
{
    /// <summary>
    /// Interaction logic for ScriptExampleView.xaml
    /// </summary>
    public partial class ScriptExampleView : UserControl
    {
        public ScriptExampleView()
        {
            InitializeComponent();
        }
    }

    public class ScriptExampleVM
    {
        private ScriptExampleModel scriptExample;
        public ScriptExampleModel ScriptExample 
        { 
            get => scriptExample; 
            set 
            {
                scriptExample = value;
                this.DescriptionFieldViewModel = new DescriptionFieldVM(this.ScriptExample);
                this.VisionSystemViewModel = new VisionSystemFieldVM(this.ScriptExample);
                this.CaveatsAndLimitationsFieldViewModel = new CaveatsAndLimitationsFieldVM(this.ScriptExample);
                this.AdditionalSettingsFieldViewModel = new AdditionalSettingsFieldVM(this.ScriptExample);
                this.WorldGridFieldViewModel = new WorldGridFieldVM(this.ScriptExample);
                this.MapFieldViewModel = new MapFieldVM(this.ScriptExample);
                this.WorldItemsFieldViewModel = new WorldItemsFieldVM(this.ScriptExample);
                this.InterfaceItemsFieldViewModel = new InterfaceItemsFieldVM(this.ScriptExample);
                this.MachineDataFieldViewModel = new MachineDataFieldVM(this.ScriptExample);
            }  
        }

        public DescriptionFieldVM DescriptionFieldViewModel { get; private set; }
        public VisionSystemFieldVM VisionSystemViewModel { get; private set; }
        public CaveatsAndLimitationsFieldVM CaveatsAndLimitationsFieldViewModel { get; private set; }
        public AdditionalSettingsFieldVM AdditionalSettingsFieldViewModel { get; private set; }
        public WorldGridFieldVM WorldGridFieldViewModel { get; private set; }
        public MapFieldVM MapFieldViewModel { get; private set; }
        public WorldItemsFieldVM WorldItemsFieldViewModel { get; private set; }
        public InterfaceItemsFieldVM InterfaceItemsFieldViewModel { get; private set; }
        public MachineDataFieldVM MachineDataFieldViewModel { get; private set; }

        public ScriptExampleVM(ScriptExampleModel scriptExample)
        {
            this.ScriptExample = scriptExample;
        }
    }
}
