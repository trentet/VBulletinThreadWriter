using System.Windows;
using VBulletinThreadWriterGUI.Models;
using VBulletinThreadWriterGUI.Views.Controls.TrainingMethod;
using VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample;
using VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.Fields;

namespace VBulletinThreadWriterGUI
{
    /// <summary>
    /// Interaction logic for TrainingMethodWindow.xaml
    /// </summary>
    public partial class TrainingMethodWindow : Window
    {
        /* View Model Property */

        public static readonly DependencyProperty ViewModelProperty
            = DependencyProperty.Register(
                  "ViewModel",
                  typeof(TrainingMethodVM),
                  typeof(TrainingMethodWindow),
                  new PropertyMetadata(new TrainingMethodVM())
             );

        public DescriptionFieldVM ViewModel
        {
            get { return (DescriptionFieldVM)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); this.DataContext = ViewModel; }
        }

        protected void TrainingMethodWindow_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ReloadVM();
        }

        public static TrainingMethodVM TrainingMethodVM;
        public TrainingMethodModel trainingMethodModel;
        public TrainingMethodModel TrainingMethodModel 
        {
            get => trainingMethodModel;
            set 
            {
                trainingMethodModel = value;
                TrainingMethodVM = new TrainingMethodVM(trainingMethodModel);
                ReloadVM();
            }
        }

        public void ReloadVM()
        {
            this.NameFieldControl.ViewModel = TrainingMethodVM.NameFieldViewModel;
            this.ScriptExampleViewControl.ViewModel = TrainingMethodVM.ScriptExampleViewModel;
        }

        public TrainingMethodWindow()
        {
            InitializeComponent();
            this.TrainingMethodModel = new TrainingMethodModel();
        }

        public TrainingMethodWindow(TrainingMethodModel trainingMethodModel)
        {
            InitializeComponent();
            this.TrainingMethodModel = trainingMethodModel;
        }
    }

    public class TrainingMethodVM
    {
        private TrainingMethodModel trainingMethodModel;
        public TrainingMethodModel TrainingMethodModel
        {
            get => trainingMethodModel;
            set
            {
                trainingMethodModel = value;
                if(TrainingMethodModel == null)
                {
                    this.NameFieldViewModel = new NameFieldVM();
                    this.ScriptExampleViewModel = new ScriptExampleVM();
                } 
                else
                {
                    this.NameFieldViewModel = new NameFieldVM(TrainingMethodModel.Name);
                    this.ScriptExampleViewModel = new ScriptExampleVM(TrainingMethodModel.ScriptExample);
                }               
            }
        }

        public NameFieldVM NameFieldViewModel { get; private set; }
        public ScriptExampleVM ScriptExampleViewModel { get; private set; }

        public TrainingMethodVM(TrainingMethodModel trainingMethodModel)
        {
            this.TrainingMethodModel = trainingMethodModel;
        }

        public TrainingMethodVM()
        {
            this.TrainingMethodModel = null;
        }
    }
}
