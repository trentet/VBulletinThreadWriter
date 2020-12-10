using System;
using System.Windows;
using VBulletinThreadWriterGUI.Views.Controls.General;
using VBulletinThreadWriterGUI.Views.Controls.General.Bases;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.ViewFields
{
    /// <summary>
    /// Interaction logic for DescriptionField.xaml
    /// </summary>
    public partial class DescriptionField : TextBoxFieldBaseControl 
    {
        public static readonly DependencyProperty
            FieldNameProperty = DependencyProperty.Register(
            "FieldName", typeof(string), typeof(DescriptionField), new PropertyMetadata(""));

        public static readonly DependencyProperty
            FieldLabelWidthProperty = DependencyProperty.Register(
            "FieldLabelWidth", typeof(double), typeof(DescriptionField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty
            FieldHeightProperty = DependencyProperty.Register(
            "FieldHeight", typeof(double), typeof(DescriptionField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty
            FieldTextBoxWidthProperty = DependencyProperty.Register(
            "FieldTextBoxWidth", typeof(double), typeof(DescriptionField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty
            FieldTextProperty = DependencyProperty.Register(
            "FieldText", typeof(string), typeof(DescriptionField), new PropertyMetadata(""));

        public static readonly DependencyProperty
            ViewModelProperty = DependencyProperty.Register(
            "ViewModel", typeof(DescriptionFieldVM), typeof(DescriptionField), new PropertyMetadata(new DescriptionFieldVM()));

        public override TextBoxFieldVM TextBoxFieldViewModel { get => this.ViewModel; }

        public DescriptionFieldVM ViewModel
        {
            get { return (DescriptionFieldVM)GetValue(ViewModelProperty); }
            set
            {
                SetValue(ViewModelProperty, value);
                this.DataContext = ViewModel;
            }
        }
        
        public DescriptionField() : base(typeof(DescriptionField))
        {
            InitializeComponent();
            this.DependencyObjectControl = this;
            this.FieldLabel = this.FieldLabelControl;
            this.FieldLabel.Loaded += Label_Loaded;
            this.FieldTextBox = this.FieldTextBoxControl;
            this.FieldTextBox.Loaded += TextBox_Loaded;
        }
    }

    public class DescriptionFieldVM : TextBoxFieldVM
    {
        public string Description { get => base.Text; set => base.Text = value; }

        public DescriptionFieldVM() : base("Description", "") { }

        public DescriptionFieldVM(string description) : base("Description", description) { }
    }
}
