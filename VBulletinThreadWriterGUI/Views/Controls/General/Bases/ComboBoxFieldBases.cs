using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Extensions;

namespace VBulletinThreadWriterGUI.Views.Controls.General.Bases
{
    public class ComboBoxFieldVM : IComboBoxFieldVM
    {
        private List<string> itemsSource = new List<string>();
        public virtual string LabelName { get; set; }
        public virtual string SelectedItem { get; set; }
        public virtual List<string> ItemsSource { get => itemsSource; set => itemsSource = value; }

        public ComboBoxFieldVM()
        {
            //this.LabelName = "";
            //this.ItemsSource = new List<string>();
            //this.SelectedItem = "";
        }

        public ComboBoxFieldVM(
            string _labelName,
            string _selectedItem,
            List<string> _itemsSource
        )
        {
            this.LabelName = _labelName;
            this.ItemsSource = _itemsSource;
            this.SelectedItem = _selectedItem;
        }
    }

    public class ComboBoxFieldBaseControl : UserControl, IComboBoxField
    {
        #region Constructor
        public DependencyObject DependencyObjectControl { get; set; }
        public Label FieldLabel { get; set; }
        public ComboBox FieldComboBox { get; set; }
        public Type UserControlType { get; private set; }

        protected ComboBoxFieldBaseControl()
        {
            // protected constructor is required so that derived controls can have default parameterless constructor which is needed for xaml 
            // also protected constructor will ensure that new control creation always use constructor by passing parameters (e.g. in this example passing of string parameter is must in order to construct control)
        }

        public ComboBoxFieldBaseControl(
            Type userControlType,
            DependencyObject dependencyObjectControl,
            Label fieldLabel,
            ComboBox fieldComboBox)
        {
            this.DependencyObjectControl = dependencyObjectControl;
            this.UserControlType = userControlType;
            this.FieldLabel = fieldLabel;
            this.FieldLabel.Loaded += Label_Loaded;
            this.FieldComboBox = fieldComboBox;
            this.FieldComboBox.Loaded += ComboBox_Loaded;
            this.ComboBoxFieldViewModel = new ComboBoxFieldVM();
            this.DataContextChanged += ComboBoxField_DataContextChanged;
        }

        public ComboBoxFieldBaseControl(Type userControlType)
        {
            this.UserControlType = userControlType;
            this.ComboBoxFieldViewModel = new ComboBoxFieldVM();
            this.DataContextChanged += ComboBoxField_DataContextChanged;
        }

        #endregion

        #region base implementation

        public virtual string FieldName
        {
            get { return (string)DependencyObjectControl.GetValue(DependencyObjectControl.GetDependencyProperty("FieldNameProperty")); }
            set { DependencyObjectControl.SetValue(DependencyObjectControl.GetDependencyProperty("FieldNameProperty"), value); }
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
            set { DependencyObjectControl.SetValue(DependencyObjectControl.GetDependencyProperty("FieldTextProperty"), value); }
        }

        public virtual double FieldComboBoxWidth
        {
            get { return (double)DependencyObjectControl.GetValue(DependencyObjectControl.GetDependencyProperty("FieldComboBoxWidthProperty")); }
            set { DependencyObjectControl.SetValue(DependencyObjectControl.GetDependencyProperty("FieldComboBoxWidthProperty"), value); }
        }

        public virtual ComboBoxFieldVM ComboBoxFieldViewModel { get; }

        public virtual void Label_Loaded(object sender, RoutedEventArgs e)
        {
            LoadLabel(sender as Label);
        }

        public virtual void LoadLabel(Label label)
        {
            if (label != null)
            {
                label.Content = ComboBoxFieldViewModel.LabelName;
            }
        }

        public virtual void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            LoadComboBox(sender as ComboBox);
        }

        public virtual void LoadComboBox(ComboBox comboBox)
        {
            if (comboBox != null)
            {
                comboBox.ItemsSource = ComboBoxFieldViewModel.ItemsSource;
                comboBox.SelectedItem = ComboBoxFieldViewModel.SelectedItem;
            }
        }

        public virtual void ComboBoxField_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            LoadLabel(this.FieldLabel);
            LoadComboBox(this.FieldComboBox);
        }

        public virtual void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxFieldViewModel.SelectedItem = this.FieldComboBox.SelectedItem as string;
        }

        public virtual void Reload()
        {
            LoadLabel(this.FieldLabel);
            LoadComboBox(this.FieldComboBox);
        }

        #endregion
    }

    public interface IComboBoxFieldVM
    {
        string LabelName { get; set; }
        string SelectedItem { get; set; }
        List<string> ItemsSource { get; set; }
    }

    public interface IComboBoxField
    {
        public double FieldHeight { get; set; }
        public double FieldComboBoxWidth { get; set; }
        public string FieldName { get; set; }
        public ComboBoxFieldVM ComboBoxFieldViewModel { get; }
        public void ComboBoxField_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e);
        public void Label_Loaded(object sender, RoutedEventArgs e);
        public void LoadLabel(Label label);
        public void ComboBox_Loaded(object sender, RoutedEventArgs e);
        public void LoadComboBox(ComboBox comboBox);
        public void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e);
    }
}
