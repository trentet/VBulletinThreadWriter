using System;
using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Views.Controls.General.Bases;
using static VBulletinThreadWriterGUI.Extensions.TypeExtensions;

namespace VBulletinThreadWriterGUI.Views.Controls.General
{
    /// <summary>
    /// Interaction logic for TextBoxField.xaml
    /// </summary>
    public partial class TextBoxField : TextBoxFieldBaseControl
    {
        public static readonly DependencyProperty 
            FieldNameProperty = DependencyProperty.Register(
            "FieldName", typeof(string), typeof(TextBoxField), new PropertyMetadata(""));
        
        public static readonly DependencyProperty 
            FieldHeightProperty = DependencyProperty.Register(
            "FieldHeight", typeof(double), typeof(TextBoxField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty
            FieldLabelWidthProperty = DependencyProperty.Register(
            "FieldLabelWidth", typeof(double), typeof(TextBoxField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty 
            FieldTextBoxWidthProperty = DependencyProperty.Register(
            "FieldTextBoxWidth", typeof(double), typeof(TextBoxField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty 
            FieldTextProperty = DependencyProperty.Register(
            "FieldText", typeof(string), typeof(TextBoxField), new PropertyMetadata(""));

        /* View Model Property */

        public static readonly DependencyProperty 
            ViewModelProperty = DependencyProperty.Register(
            "ViewModel", typeof(TextBoxFieldVM), typeof(TextBoxField), new PropertyMetadata(new TextBoxFieldVM()));
        
        public TextBoxField() : base(typeof(TextBoxField))
        {
            InitializeComponent();
            this.DependencyObjectControl = this;
            this.FieldLabel = this.FieldLabelControl;
            this.FieldLabel.Loaded += Label_Loaded;
            this.FieldTextBox = this.FieldTextBoxControl;
            this.FieldTextBox.Loaded += TextBox_Loaded;
        }
    }
}
