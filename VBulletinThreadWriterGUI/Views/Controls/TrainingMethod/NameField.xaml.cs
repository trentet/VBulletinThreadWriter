using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Views.Controls.General;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod
{
    /// <summary>
    /// Interaction logic for NameField.xaml
    /// </summary>
    public partial class NameField : UserControl
    {
        public static readonly DependencyProperty FieldNameProperty
            = DependencyProperty.Register(
                  "FieldName",
                  typeof(string),
                  typeof(NameField),
                  new PropertyMetadata("")
              );

        public string FieldName
        {
            get { return (string)GetValue(FieldNameProperty); }
            set { SetValue(FieldNameProperty, value); }
        }

        public static readonly DependencyProperty FieldHeightProperty
            = DependencyProperty.Register(
                  "FieldHeight",
                  typeof(int),
                  typeof(NameField),
                  new PropertyMetadata(0)
              );

        public int FieldHeight
        {
            get { return (int)GetValue(FieldHeightProperty); }
            set { SetValue(FieldHeightProperty, value); }
        }

        public static readonly DependencyProperty FieldTextBoxWidthProperty
            = DependencyProperty.Register(
                  "FieldTextBoxWidth",
                  typeof(int),
                  typeof(NameField),
                  new PropertyMetadata(0)
             );

        public int FieldTextBoxWidth
        {
            get { return (int)GetValue(FieldTextBoxWidthProperty); }
            set { SetValue(FieldTextBoxWidthProperty, value); }
        }

        public static readonly DependencyProperty FieldTextProperty
            = DependencyProperty.Register(
                  "FieldText",
                  typeof(string),
                  typeof(NameField),
                  new PropertyMetadata("")
             );

        public string FieldText
        {
            get { return (string)GetValue(FieldTextProperty); }
            set { SetValue(FieldTextProperty, value); }
        }

        /* View Model Property */

        public static readonly DependencyProperty ViewModelProperty
            = DependencyProperty.Register(
                  "ViewModel",
                  typeof(NameFieldVM),
                  typeof(NameField),
                  new PropertyMetadata(new NameFieldVM())
             );

        public NameFieldVM ViewModel
        {
            get { return (NameFieldVM)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); this.DataContext = ViewModel; }
        }

        protected void NameField_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.NameFieldTextBox.FieldName = ViewModel.Name;
            this.NameFieldTextBox.FieldText = ViewModel.Text;
        }

        public NameField()
        {
            InitializeComponent();
            this.DataContextChanged += NameField_DataContextChanged;
        }
    }

    public class NameFieldVM : TextBoxFieldVM
    {
        public string Name { get => base.Text; set => base.Text = value; }

        public NameFieldVM()
        {
            this.LabelName = "Name";
        }

        public NameFieldVM(string name) : base("Name", name)
        {
            
        }
    }
}
