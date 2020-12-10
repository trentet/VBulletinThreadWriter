using System;
using System.Windows;
using VBulletinThreadWriterGUI.Views.Controls.General.Bases;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod
{
    /// <summary>
    /// Interaction logic for NameField.xaml
    /// </summary>
    public partial class NameField : TextBoxFieldBaseControl
    {
        public static readonly DependencyProperty 
            FieldNameProperty = DependencyProperty.Register(
            "FieldName", typeof(string), typeof(NameField), new PropertyMetadata(""));

        public static readonly DependencyProperty
            FieldLabelWidthProperty = DependencyProperty.Register(
            "FieldLabelWidth", typeof(double), typeof(NameField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty 
            FieldHeightProperty = DependencyProperty.Register(
            "FieldHeight", typeof(double), typeof(NameField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty 
            FieldTextBoxWidthProperty = DependencyProperty.Register(
            "FieldTextBoxWidth", typeof(double), typeof(NameField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty 
            FieldTextProperty = DependencyProperty.Register(
            "FieldText", typeof(string), typeof(NameField), new PropertyMetadata(""));

        public static readonly DependencyProperty 
            ViewModelProperty = DependencyProperty.Register(
            "ViewModel", typeof(NameFieldVM), typeof(NameField), new PropertyMetadata(new NameFieldVM()));

        public override TextBoxFieldVM TextBoxFieldViewModel { get => this.ViewModel; }

        public NameFieldVM ViewModel
        {
            get { return (NameFieldVM)GetValue(ViewModelProperty); }
            set 
            { 
                SetValue(ViewModelProperty, value); 
                this.DataContext = ViewModel; 
            }
        }

        public NameField() : base(typeof(NameField))
        {
            InitializeComponent();
            this.DependencyObjectControl = this;
            this.FieldLabel = this.FieldLabelControl;
            this.FieldLabel.Loaded += Label_Loaded;
            this.FieldTextBox = this.FieldTextBoxControl;
            this.FieldTextBox.Loaded += TextBox_Loaded;
        }
    }

    public class NameFieldVM : TextBoxFieldVM
    {
        public string Name { get => base.Text; set => base.Text = value; }

        public NameFieldVM() : base("Name", "") { }

        public NameFieldVM(string name) : base("Name", name) { }
    }
}
