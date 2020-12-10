using System.Windows;
using VBulletinThreadWriterGUI.Models;
using VBulletinThreadWriterGUI.Views.Controls.TrainingMethod;
using VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample;
using VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.ViewFields;

namespace VBulletinThreadWriterGUI
{
    /// <summary>
    /// Interaction logic for TrainingMethodWindow.xaml
    /// </summary>
    public partial class TrainingMethodWindow : Window
    {
        /* View Model Property */

        public static readonly DependencyProperty 
            ViewModelProperty = DependencyProperty.Register(
            "ViewModel", typeof(TrainingMethodVM), typeof(TrainingMethodWindow), new PropertyMetadata(new TrainingMethodVM()));

        public TrainingMethodVM TrainingMethodViewModel
        {
            get { return (TrainingMethodVM)GetValue(ViewModelProperty); }
            set 
            { 
                SetValue(ViewModelProperty, value); 
                this.DataContext = TrainingMethodViewModel; 
            }
        }

        public void TrainingMethodWindow_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Reload();
        }

        //public static TrainingMethodVM TrainingMethodVM;
        public TrainingMethodModel trainingMethodModel;
        public TrainingMethodModel TrainingMethodModel 
        {
            get => trainingMethodModel;
            set 
            {
                trainingMethodModel = value;
                TrainingMethodViewModel = new TrainingMethodVM(trainingMethodModel);
                Reload();
            }
        }

        public void Reload()
        {
            this.NameFieldControl.ViewModel = TrainingMethodViewModel.NameFieldViewModel;
            this.ScriptExampleViewControl.ViewModel = TrainingMethodViewModel.ScriptExampleViewModel;
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
