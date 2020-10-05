using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VBulletinThreadWriterGUI.Views.Controls.General
{
    /// <summary>
    /// Interaction logic for FileSelectionTextBoxField.xaml
    /// </summary>
    public partial class FileSelectionTextBoxField : UserControl
    {
        /* Start of Custom Properties */

        /* Field Name Property */

        public static readonly DependencyProperty FieldNameProperty
            = DependencyProperty.Register(
                  "FieldName",
                  typeof(string),
                  typeof(FileSelectionTextBoxField),
                  new PropertyMetadata("")
             );

        public string FieldName
        {
            get { return (string)GetValue(FieldNameProperty); }
            set { SetValue(FieldNameProperty, value); }
        }

        /* Field TextBox Text Property */

        public static readonly DependencyProperty FieldTextBoxTextProperty
            = DependencyProperty.Register(
                  "FieldTextBoxText",
                  typeof(string),
                  typeof(FileSelectionTextBoxField),
                  new PropertyMetadata("")
              );

        public string FieldTextBoxText
        {
            get { return (string)GetValue(FieldTextBoxTextProperty); }
            set { SetValue(FieldTextBoxTextProperty, value); }
        }

        /* Field Button Text Property */

        public static readonly DependencyProperty FieldButtonTextProperty
            = DependencyProperty.Register(
                  "FieldButtonText",
                  typeof(string),
                  typeof(FileSelectionTextBoxField),
                  new PropertyMetadata("")
              );

        public string FieldButtonText
        {
            get { return (string)GetValue(FieldButtonTextProperty); }
            set { SetValue(FieldButtonTextProperty, value); }
        }

        /* Field Button Width Property */

        public static readonly DependencyProperty FieldButtonWidthProperty
            = DependencyProperty.Register(
                  "FieldButtonWidth",
                  typeof(int),
                  typeof(FileSelectionTextBoxField),
                  new PropertyMetadata(0)
              );

        public int FieldButtonWidth
        {
            get { return (int)GetValue(FieldButtonWidthProperty); }
            set { SetValue(FieldButtonWidthProperty, value); }
        }

        /* Field Height Property */

        public static readonly DependencyProperty FieldHeightProperty
            = DependencyProperty.Register(
                  "FieldHeight",
                  typeof(int),
                  typeof(FileSelectionTextBoxField),
                  new PropertyMetadata(0)
              );

        public int FieldHeight
        {
            get { return (int)GetValue(FieldHeightProperty); }
            set { SetValue(FieldHeightProperty, value); }
        }

        /* Field TextBox Width Property */

        public static readonly DependencyProperty FieldTextBoxWidthProperty
            = DependencyProperty.Register(
                  "FieldTextBoxWidth",
                  typeof(int),
                  typeof(FileSelectionTextBoxField),
                  new PropertyMetadata(0)
             );

        public int FieldTextBoxWidth
        {
            get { return (int)GetValue(FieldTextBoxWidthProperty); }
            set { SetValue(FieldTextBoxWidthProperty, value); }
        }

        public static readonly DependencyProperty ViewModelProperty
            = DependencyProperty.Register(
                  "ViewModel",
                  typeof(FileSelectionTextBoxFieldVM),
                  typeof(FileSelectionTextBoxField),
                  new PropertyMetadata(new FileSelectionTextBoxFieldVM())
             );

        public FileSelectionTextBoxFieldVM ViewModel
        {
            get { return (FileSelectionTextBoxFieldVM)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); this.FieldFileSelectionTextBox.DataContext = ViewModel; }
        }

        private void TextBox_DataContextChanged(object sender, RoutedEventArgs e)
        {
            TextBox_Loaded(sender, e);
            Button_Loaded(sender, e);
        }

        private void TextBox_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Get the TextBox reference.
            var textBox = sender as TextBox;

            // ... Assign the ItemsSource to the List.
            textBox.Text = ViewModel.TextBoxText;
        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Get the TextBox reference.
            var button = sender as Button;

            // ... Assign the ItemsSource to the List.
            button.Content = ViewModel.ButtonText;
        }
        public FileSelectionTextBoxField()
        {
            InitializeComponent();
        }
    }

    public class FileSelectionTextBoxFieldVM
    {
        public string DefaultTextBoxText { get; set; }
        public string TextBoxText { get => this.SelectedFiles.Count > 0 ? string.Join(", ", this.SelectedFiles) : this.DefaultTextBoxText; }
        public List<string> SelectedFiles { get; set; }
        public string ButtonText { get; set; }

        public FileSelectionTextBoxFieldVM()
        {
            this.DefaultTextBoxText = "";
            this.SelectedFiles = new List<string>();
            this.ButtonText = "...";
        }

        public FileSelectionTextBoxFieldVM(string defaultTextBoxText)
        {
            this.DefaultTextBoxText = defaultTextBoxText;
            this.SelectedFiles = new List<string>();
            this.ButtonText = "...";
        }

        public FileSelectionTextBoxFieldVM(List<string> selectedFiles)
        {
            this.DefaultTextBoxText = "";
            this.SelectedFiles = selectedFiles;
            this.ButtonText = "...";
        }

        public FileSelectionTextBoxFieldVM(string defaultTextBoxText, List<string> selectedFiles)
        {
            this.DefaultTextBoxText = defaultTextBoxText;
            this.SelectedFiles = selectedFiles;
            this.ButtonText = "...";
        }
    }
}
