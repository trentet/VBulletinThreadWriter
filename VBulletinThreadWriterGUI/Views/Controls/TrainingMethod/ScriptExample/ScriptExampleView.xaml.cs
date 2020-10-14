using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;
using VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.Fields;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample
{
    /// <summary>
    /// Interaction logic for ScriptExampleView.xaml
    /// </summary>
    public partial class ScriptExampleView : UserControl
    {
        public static readonly DependencyProperty ViewModelProperty
            = DependencyProperty.Register(
                  "ViewModel",
                  typeof(ScriptExampleVM),
                  typeof(ScriptExampleView),
                  new PropertyMetadata(new ScriptExampleVM())
             );

        public ScriptExampleVM ViewModel
        {
            get { return (ScriptExampleVM)GetValue(ViewModelProperty); }
            set
            {
                SetValue(ViewModelProperty, value);
                this.DescriptionFieldView.ViewModel = ViewModel.DescriptionFieldViewModel;
                //this.VisionSystemFieldView.ViewModel = ViewModel.VisionSystemViewModel;
                //this.CaveatsAndLimitationsFieldView.ViewModel = ViewModel.CaveatsAndLimitationsFieldViewModel;
                this.AdditionalSettingsFieldView.ViewModel = ViewModel.AdditionalSettingsFieldViewModel;
                this.WorldGridFieldView.ViewModel = ViewModel.WorldGridFieldViewModel;
                this.MapFieldView.ViewModel = ViewModel.MapFieldViewModel;
                //this.WorldItemsFieldView.ViewModel = ViewModel.WorldItemsFieldViewModel;
                //this.InterfaceItemsFieldView.ViewModel = ViewModel.InterfaceItemsFieldViewModel;
                this.MachineDataFieldView.ViewModel = ViewModel.MachineDataFieldViewModel;
            }
        }

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

        public ScriptExampleVM()
        {
            this.ScriptExample = new ScriptExampleModel();
        }

        public ScriptExampleVM(ScriptExampleModel scriptExample)
        {
            this.ScriptExample = scriptExample;
        }
    }
}
