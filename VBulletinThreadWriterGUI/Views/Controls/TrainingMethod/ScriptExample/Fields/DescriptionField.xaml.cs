using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;
using VBulletinThreadWriterGUI.Views.Controls.General;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.Fields
{
    /// <summary>
    /// Interaction logic for DescriptionField.xaml
    /// </summary>
    public partial class DescriptionField : UserControl
    {
        /* View Model Property */

        public static readonly DependencyProperty ViewModelProperty
            = DependencyProperty.Register(
                  "ViewModel",
                  typeof(DescriptionFieldVM),
                  typeof(DescriptionField),
                  new PropertyMetadata(new DescriptionFieldVM())
             );

        public DescriptionFieldVM ViewModel
        {
            get { return (DescriptionFieldVM)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); this.DataContext = ViewModel; }
        }

        protected void DescriptionField_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.DescriptionFieldTextBox.FieldName = ViewModel.LabelName;
            this.DescriptionFieldTextBox.FieldText = ViewModel.Text;
        }

        public DescriptionField()
        {
            InitializeComponent();
            this.DataContextChanged += DescriptionField_DataContextChanged;
        }
    }

    public class DescriptionFieldVM : TextBoxFieldVM
    {
        private ScriptExampleModel scriptExample;
        public ScriptExampleModel ScriptExample 
        { 
            get => scriptExample;
            set 
            {
                scriptExample = value;
                this.Description = scriptExample.Description;
            } 
        }
        public string Description 
        { 
            get => ScriptExample.Description;
            set
            {
                ScriptExample.Description = value;
                this.Text = ScriptExample.Description;
            } 
        }

        public DescriptionFieldVM()
        {
            this.LabelName = "Description";
            this.ScriptExample = new ScriptExampleModel();
        }

        public DescriptionFieldVM(ScriptExampleModel scriptExample) : base("Description", scriptExample.Description)
        {
            this.ScriptExample = scriptExample;
        }
    }
}
