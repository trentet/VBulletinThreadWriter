using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;
using VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.ViewFields;

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
                this.VisionSystemFieldView.ViewModel = ViewModel.VisionSystemViewModel;
                this.CaveatsAndLimitationsFieldView.ViewModel = ViewModel.CaveatsAndLimitationsFieldViewModel;
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
            this.DataContextChanged += ScriptExampleView_DataContextChanged;
            //this.DescriptionFieldView.FieldComboBoxSelectionChanged += GameField_SelectionChanged;
            //this.VisionSystemFieldView.FieldComboBoxSelectionChanged += VisionSystemField_SelectionChanged;
            //this.CaveatsAndLimitationsFieldView.FieldComboBoxSelectionChanged += TrainingMethodField_SelectionChanged;
            //this.AdditionalSettingsFieldView.FieldComboBoxSelectionChanged += TrainingMethodField_SelectionChanged;
            //this.WorldGridFieldView.FieldComboBoxSelectionChanged += TrainingMethodField_SelectionChanged;
            //this.MapFieldView.FieldComboBoxSelectionChanged += TrainingMethodField_SelectionChanged;
            //this.WorldItemsFieldView.FieldComboBoxSelectionChanged += TrainingMethodField_SelectionChanged;
            //this.InterfaceItemsFieldView.FieldComboBoxSelectionChanged += TrainingMethodField_SelectionChanged;
            //this.MachineDataFieldView.FieldComboBoxSelectionChanged += TrainingMethodField_SelectionChanged;
            this.ViewModel = new ScriptExampleVM();
        }

        public ScriptExampleView(ScriptExampleModel scriptExampleModel)
        {
            InitializeComponent();
            this.DataContextChanged += ScriptExampleView_DataContextChanged;
            //this.DescriptionFieldView.FieldComboBoxSelectionChanged += GameField_SelectionChanged;
            //this.VisionSystemFieldView.FieldComboBoxSelectionChanged += VisionSystemField_SelectionChanged;
            //this.CaveatsAndLimitationsFieldView.FieldComboBoxSelectionChanged += TrainingMethodField_SelectionChanged;
            //this.AdditionalSettingsFieldView.FieldComboBoxSelectionChanged += TrainingMethodField_SelectionChanged;
            //this.WorldGridFieldView.FieldComboBoxSelectionChanged += TrainingMethodField_SelectionChanged;
            //this.MapFieldView.FieldComboBoxSelectionChanged += TrainingMethodField_SelectionChanged;
            //this.WorldItemsFieldView.FieldComboBoxSelectionChanged += TrainingMethodField_SelectionChanged;
            //this.InterfaceItemsFieldView.FieldComboBoxSelectionChanged += TrainingMethodField_SelectionChanged;
            //this.MachineDataFieldView.FieldComboBoxSelectionChanged += TrainingMethodField_SelectionChanged;
            this.ViewModel = new ScriptExampleVM(scriptExampleModel);
        }

        public void ScriptExampleView_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!(sender is ScriptExampleView) || sender == null)
            {
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                throw new ArgumentException("MainWindowView_DataContextChanged sender is not a MainWindowView. Actual: " + sender.GetType().FullName);
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
            else
            {
                ReloadViewModels();
            }
        }

        public void VisionSystemField_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... Get the ComboBox.
            var comboBox = sender as ComboBox;

            // ... Set SelectedItem as Window Title.
            ViewModel.VisionSystemViewModel.SelectedVisionSystem =
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                (comboBox.SelectedItem as string) == "" || (comboBox.SelectedItem as string) == null
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
                ?
                (VisionSystems?)null
                :
                ViewModel.VisionSystemViewModel.VisionSystemsItemSource.Where(o => o.ToDescription().Equals(comboBox.SelectedItem as string)).First();
        }

        public void ReloadViewModels()
        {
            this.DescriptionFieldView.ViewModel = this.ViewModel.DescriptionFieldViewModel;
            this.VisionSystemFieldView.ViewModel = this.ViewModel.VisionSystemViewModel;
            this.CaveatsAndLimitationsFieldView.ViewModel = this.ViewModel.CaveatsAndLimitationsFieldViewModel;
            this.AdditionalSettingsFieldView.ViewModel = this.ViewModel.AdditionalSettingsFieldViewModel;
            this.WorldGridFieldView.ViewModel = this.ViewModel.WorldGridFieldViewModel;
            this.MapFieldView.ViewModel = this.ViewModel.MapFieldViewModel;
            //this.WorldItemsFieldView.ViewModel = this.ViewModel.WorldItemsFieldViewModel;
            //this.InterfaceItemsFieldView.ViewModel = this.ViewModel.InterfaceItemsFieldViewModel;
            this.MachineDataFieldView.ViewModel = this.ViewModel.MachineDataFieldViewModel;
        }
    }

    public class ScriptExampleVM
    {
        private ScriptExampleModel scriptExample;
        public ScriptExampleModel ScriptExampleModel
        { 
            get => scriptExample; 
            set 
            {
                scriptExample = value;

                if(this.ScriptExampleModel == null)
                {
                    this.ScriptExampleModel = new ScriptExampleModel();
                }
                
                    this.DescriptionFieldViewModel = new DescriptionFieldVM(this.ScriptExampleModel.Description);
                    this.VisionSystemViewModel = new VisionSystemFieldVM(this.ScriptExampleModel.VisionSystem);
                    this.CaveatsAndLimitationsFieldViewModel = new CaveatsAndLimitationsFieldVM(this.ScriptExampleModel.CaveatsAndLimitations);
                    this.AdditionalSettingsFieldViewModel = new AdditionalSettingsFieldVM(this.ScriptExampleModel.AdditionalSettingsSection);
                    this.WorldGridFieldViewModel = new WorldGridFieldVM(this.ScriptExampleModel);
                    this.MapFieldViewModel = new MapFieldVM(this.ScriptExampleModel);
                    this.WorldItemsFieldViewModel = new WorldItemsFieldVM(this.ScriptExampleModel);
                    this.InterfaceItemsFieldViewModel = new InterfaceItemsFieldVM(this.ScriptExampleModel);
                    this.MachineDataFieldViewModel = new MachineDataFieldVM(this.ScriptExampleModel);
                
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
            this.ScriptExampleModel = new ScriptExampleModel();
        }

        public ScriptExampleVM(ScriptExampleModel scriptExample)
        {
            this.ScriptExampleModel = scriptExample;
        }
    }
}
