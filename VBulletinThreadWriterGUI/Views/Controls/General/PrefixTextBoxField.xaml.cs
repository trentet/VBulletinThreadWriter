using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace VBulletinThreadWriterGUI.Views.Controls.General
{
    /// <summary>
    /// Interaction logic for PrefixTextBoxField.xaml
    /// </summary>
    public partial class PrefixTextBoxField : UserControl
    {
        public static readonly DependencyProperty FieldNameProperty
            = DependencyProperty.Register(
                  "FieldName",
                  typeof(string),
                  typeof(PrefixTextBoxField),
                  new PropertyMetadata("")
              );

        public string FieldName
        {
            get { return (string)GetValue(FieldNameProperty); }
            set { SetValue(FieldNameProperty, value); }
        }

        public static readonly DependencyProperty FieldPrefixNameProperty
            = DependencyProperty.Register(
                  "FieldPrefixName",
                  typeof(string),
                  typeof(PrefixTextBoxField),
                  new PropertyMetadata("")
              );

        public string FieldPrefixName
        {
            get { return (string)GetValue(FieldPrefixNameProperty); }
            set { SetValue(FieldPrefixNameProperty, value); }
        }

        public static readonly DependencyProperty FieldHeightProperty
            = DependencyProperty.Register(
                  "FieldHeight",
                  typeof(double),
                  typeof(PrefixTextBoxField),
                  new PropertyMetadata(Double.NaN)
              );

        public double FieldHeight
        {
            get { return (double)GetValue(FieldHeightProperty); }
            set { SetValue(FieldHeightProperty, value); }
        }

        public static readonly DependencyProperty FieldTextBoxWidthProperty
            = DependencyProperty.Register(
                  "FieldTextBoxWidth",
                  typeof(double),
                  typeof(PrefixTextBoxField),
                  new PropertyMetadata(Double.NaN)
             );
              
        public double FieldTextBoxWidth
        {
            get { return (double)GetValue(FieldTextBoxWidthProperty); }
            set { SetValue(FieldTextBoxWidthProperty, value); }
        }

        public static readonly DependencyProperty FieldTextProperty
            = DependencyProperty.Register(
                  "FieldText",
                  typeof(string),
                  typeof(PrefixTextBoxField),
                  new PropertyMetadata("")
             );
              
        public string FieldText
        {
            get { return (string)GetValue(FieldTextProperty); }
            set { SetValue(FieldTextProperty, value); }
        }

        public PrefixTextBoxField()
        {
            InitializeComponent();
        }
    }

    public class PrefixTextBoxFieldVM
    {
        public string LabelName { get; set; }
        public string SelectedItem { get; set; }
        public List<string> ItemsSource { get; set; }

        public PrefixTextBoxFieldVM()
        {
            this.LabelName = "";
            this.SelectedItem = "";
            this.ItemsSource = new List<string>();
        }

        public PrefixTextBoxFieldVM(string labelName, string selectedItem, List<string> itemsSource)
        {
            this.LabelName = labelName;
            this.SelectedItem = selectedItem;
            this.ItemsSource = itemsSource;
        }
    }
}
