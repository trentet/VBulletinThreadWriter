using System;
using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Extensions;

namespace VBulletinThreadWriterGUI.Views.Controls.General.Bases
{
    public class TextBoxFieldVM : ITextBoxFieldVM
    {
        public virtual string LabelName { get; set; }
        public virtual string Text { get; set; }

        public TextBoxFieldVM()
        {
            this.LabelName = "";
            this.Text = "";
        }

        public TextBoxFieldVM(string labelName, string text)
        {
            this.LabelName = labelName;
            this.Text = text;
        }
    }

    public class TextBoxFieldBaseControl : UserControl, ITextBoxField
    {
        #region Constructor
        public DependencyObject DependencyObjectControl { get; set; }
        public Label FieldLabel { get; set; }
        public TextBox FieldTextBox { get; set; }
        public Type UserControlType { get; private set; }

        protected TextBoxFieldBaseControl()
        {
            // protected constructor is required so that derived controls can have default parameterless constructor which is needed for xaml 
            // also protected constructor will ensure that new control creation always use constructor by passing parameters (e.g. in this example passing of string parameter is must in order to construct control)
        }

        public TextBoxFieldBaseControl(
            Type userControlType,
            DependencyObject dependencyObjectControl,
            Label fieldLabel,
            TextBox fieldTextBox)
        {
            this.DependencyObjectControl = dependencyObjectControl;
            this.UserControlType = userControlType;
            this.FieldLabel = fieldLabel;
            this.FieldLabel.Loaded += Label_Loaded;
            this.FieldTextBox = fieldTextBox;
            this.FieldTextBox.Loaded += TextBox_Loaded;
            this.TextBoxFieldViewModel = new TextBoxFieldVM();// FieldName, FieldText);
            this.DataContextChanged += TextBoxField_DataContextChanged;
        }

        public TextBoxFieldBaseControl(Type userControlType)
        {
            this.UserControlType = userControlType;
            this.TextBoxFieldViewModel = new TextBoxFieldVM();// FieldName, FieldText);
            this.DataContextChanged += TextBoxField_DataContextChanged;
        }

        #endregion

        #region base implementation

        public virtual string FieldName
        {
            get 
            {
                var p = DependencyObjectControl.GetDependencyProperty("FieldNameProperty");
                var fieldName = (string)DependencyObjectControl.GetValue(p);
                return fieldName; 
            }
            set 
            {
                var p = DependencyObjectControl.GetDependencyProperty("FieldNameProperty");
                DependencyObjectControl.SetValue(p, value);
                TextBoxFieldViewModel.LabelName = FieldName;
            }
        }

        public virtual double FieldLabelWidth
        {
            get { return (double)DependencyObjectControl.GetValue(DependencyObjectControl.GetDependencyProperty("FieldLabelWidthProperty")); }
            set { DependencyObjectControl.SetValue(DependencyObjectControl.GetDependencyProperty("FieldLabelWidthProperty"), value); }
        }

        public virtual double FieldTextBoxWidth
        {
            get { return (double)DependencyObjectControl.GetValue(DependencyObjectControl.GetDependencyProperty("FieldTextBoxWidthProperty")); }
            set { DependencyObjectControl.SetValue(DependencyObjectControl.GetDependencyProperty("FieldTextBoxWidthProperty"), value); }
        }

        public virtual double FieldHeight
        {
            get { return (double)DependencyObjectControl.GetValue(DependencyObjectControl.GetDependencyProperty("FieldHeightProperty")); }
            set { DependencyObjectControl.SetValue(DependencyObjectControl.GetDependencyProperty("FieldHeightProperty"), value); }
        }

        public virtual string FieldText
        {
            get { return (string)DependencyObjectControl.GetValue(DependencyObjectControl.GetDependencyProperty("FieldTextProperty")); }
            set 
            { 
                DependencyObjectControl.SetValue(DependencyObjectControl.GetDependencyProperty("FieldTextProperty"), value);
                TextBoxFieldViewModel.Text = FieldText;
            }
        }

        public virtual TextBoxFieldVM TextBoxFieldViewModel { get; }

        public virtual void Label_Loaded(object sender, RoutedEventArgs e)
        {
            LoadLabel(sender as Label);
        }

        public virtual void LoadLabel(Label label)
        {
            if (label != null)
            {
                label.Width = FieldLabelWidth;
                label.Content = TextBoxFieldViewModel.LabelName;
            }
        }

        public virtual void TextBox_Loaded(object sender, RoutedEventArgs e)
        {
            LoadTextBox(sender as TextBox);
        }

        public virtual void LoadTextBox(TextBox textBox)
        {
            if (textBox != null)
            {
                textBox.Text = TextBoxFieldViewModel.Text;
            }
        }

        public virtual void TextBoxField_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Reload();
        }

        public virtual void Reload()
        {
            LoadLabel(this.FieldLabel);
            LoadTextBox(this.FieldTextBox);
        }
        #endregion
    }

    public interface ITextBoxField
    {
        public double FieldHeight { get; set; }
        public double FieldTextBoxWidth { get; set; }
        public string FieldName { get; set; }
        public string FieldText { get; set; }
        public TextBoxFieldVM TextBoxFieldViewModel { get; }
        public void TextBoxField_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e);
        public void Label_Loaded(object sender, RoutedEventArgs e);
        public void LoadLabel(Label label);
        public void TextBox_Loaded(object sender, RoutedEventArgs e);
        public void LoadTextBox(TextBox textBox);
    }

    public interface ITextBoxFieldVM
    {
        string LabelName { get; set; }
        string Text { get; set; }
    }
}
