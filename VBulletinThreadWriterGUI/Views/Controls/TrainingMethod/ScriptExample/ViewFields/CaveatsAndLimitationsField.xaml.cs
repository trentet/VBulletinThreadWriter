using System;
using System.Windows;
using VBulletinThreadWriterGUI.Views.Controls.General;
using VBulletinThreadWriterGUI.Views.Controls.General.Bases;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.ViewFields
{
    /// <summary>
    /// Interaction logic for CaveatsAndLimitationsField.xaml
    /// </summary>
    public partial class CaveatsAndLimitationsField : TextBoxFieldBaseControl
    {
        public static readonly DependencyProperty 
            FieldNameProperty = DependencyProperty.Register(
            "FieldName", typeof(string), typeof(CaveatsAndLimitationsField), new PropertyMetadata(""));

        public static readonly DependencyProperty
            FieldLabelWidthProperty = DependencyProperty.Register(
            "FieldLabelWidth", typeof(double), typeof(CaveatsAndLimitationsField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty 
            FieldHeightProperty = DependencyProperty.Register(
            "FieldHeight", typeof(double), typeof(CaveatsAndLimitationsField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty 
            FieldTextBoxWidthProperty = DependencyProperty.Register(
            "FieldTextBoxWidth", typeof(double), typeof(CaveatsAndLimitationsField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty 
            FieldTextProperty = DependencyProperty.Register(
            "FieldText", typeof(string), typeof(CaveatsAndLimitationsField), new PropertyMetadata(""));

        public static readonly DependencyProperty 
            ViewModelProperty = DependencyProperty.Register(
            "ViewModel", typeof(CaveatsAndLimitationsFieldVM), typeof(CaveatsAndLimitationsField), new PropertyMetadata(new CaveatsAndLimitationsFieldVM()));
        
        public override TextBoxFieldVM TextBoxFieldViewModel { get => this.ViewModel; }

        public CaveatsAndLimitationsFieldVM ViewModel
        {
            get { return (CaveatsAndLimitationsFieldVM)GetValue(ViewModelProperty); }
            set
            {
                SetValue(ViewModelProperty, value);
                this.DataContext = ViewModel;
            }
        }

        public CaveatsAndLimitationsField() : base(typeof(CaveatsAndLimitationsField))
        {
            InitializeComponent();
            this.DependencyObjectControl = this;
            this.FieldLabel = this.FieldLabelControl;
            this.FieldLabel.Loaded += Label_Loaded;
            this.FieldTextBox = this.FieldTextBoxControl;
            this.FieldTextBox.Loaded += TextBox_Loaded;
        }
    }

    public class CaveatsAndLimitationsFieldVM : TextBoxFieldVM
    {
        public CaveatsAndLimitationsFieldVM() : base("Caveats/Limitations", "") { }

        public CaveatsAndLimitationsFieldVM(string text) : base("Caveats/Limitations", text) { }
    }
}
