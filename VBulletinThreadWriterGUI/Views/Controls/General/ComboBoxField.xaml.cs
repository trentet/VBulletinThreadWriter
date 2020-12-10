using System;
using System.Windows;
using VBulletinThreadWriterGUI.Views.Controls.General.Bases;

namespace VBulletinThreadWriterGUI.Views.Controls.General
{
    /// <summary>
    /// Interaction logic for ComboBoxField.xaml
    /// </summary>
    public partial class ComboBoxField : ComboBoxFieldBaseControl
    {
        /* Start of Custom Properties */

        public static readonly DependencyProperty 
            FieldHeightProperty = DependencyProperty.Register(
            "FieldHeight", typeof(double), typeof(ComboBoxField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty
            FieldComboBoxWidthProperty = DependencyProperty.Register(
            "FieldComboBoxWidth", typeof(double), typeof(ComboBoxField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty
            FieldNameProperty = DependencyProperty.Register(
            "FieldName", typeof(string), typeof(ComboBoxField), new PropertyMetadata(""));

        public static readonly DependencyProperty
            ViewModelProperty = DependencyProperty.Register(
            "ViewModel", typeof(ComboBoxFieldVM), typeof(ComboBoxField), new PropertyMetadata(new ComboBoxFieldVM()));

        public ComboBoxField() : base(typeof(ComboBoxField))
        {
            InitializeComponent();
            this.DependencyObjectControl = this;
            this.FieldLabel = this.FieldLabelControl;
            this.FieldLabel.Loaded += Label_Loaded;
            this.FieldComboBox = this.FieldComboBoxControl;
            this.FieldComboBox.Loaded += ComboBox_Loaded;
        }
    }
}
