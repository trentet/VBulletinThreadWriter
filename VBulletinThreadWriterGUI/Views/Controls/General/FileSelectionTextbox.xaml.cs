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
    /// Interaction logic for FileSelectionTextBox.xaml
    /// </summary>
    public partial class FileSelectionTextBox : UserControl
    {
        /* Start of Custom Properties */

        /* Field TextBox Text Property */

        public static readonly DependencyProperty FieldTextBoxTextProperty
            = DependencyProperty.Register(
                  "FieldTextBoxText",
                  typeof(string),
                  typeof(FileSelectionTextBox),
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
                  typeof(FileSelectionTextBox),
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
                  typeof(double),
                  typeof(FileSelectionTextBox),
                  new PropertyMetadata(Double.NaN)
              );

        public double FieldButtonWidth
        {
            get { return (double)GetValue(FieldButtonWidthProperty); }
            set { SetValue(FieldButtonWidthProperty, value); }
        }

        /* Field Height Property */

        public static readonly DependencyProperty FieldHeightProperty
            = DependencyProperty.Register(
                  "FieldHeight",
                  typeof(double),
                  typeof(FileSelectionTextBox),
                  new PropertyMetadata(Double.NaN)
              );

        public double FieldHeight
        {
            get { return (double)GetValue(FieldHeightProperty); }
            set { SetValue(FieldHeightProperty, value); }
        }

        /* Field TextBox Width Property */

        public static readonly DependencyProperty FieldTextBoxWidthProperty
            = DependencyProperty.Register(
                  "FieldTextBoxWidth",
                  typeof(double),
                  typeof(FileSelectionTextBox),
                  new PropertyMetadata(Double.NaN)
             );

        public double FieldTextBoxWidth
        {
            get { return (double)GetValue(FieldTextBoxWidthProperty); }
            set { SetValue(FieldTextBoxWidthProperty, value); }
        }

        public static readonly DependencyProperty ViewModelProperty
            = DependencyProperty.Register(
                  "ViewModel",
                  typeof(FileSelectionTextBoxVM),
                  typeof(FileSelectionTextBox),
                  new PropertyMetadata(new FileSelectionTextBoxVM())
             );

        public FileSelectionTextBoxVM ViewModel
        {
            get { return (FileSelectionTextBoxVM)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); this.FieldTextBox.DataContext = ViewModel; }
        }

        public FileSelectionTextBox()
        {
            InitializeComponent();
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
    }

    public class FileSelectionTextBoxVM
    {
        public string DefaultTextBoxText { get; set; }
        public string TextBoxText { get => this.SelectedFiles.Count > 0 ? string.Join(", ", this.SelectedFiles) : this.DefaultTextBoxText; }
        public List<string> SelectedFiles { get; set; }
        public string ButtonText { get; set; }

        public FileSelectionTextBoxVM()
        {
            this.DefaultTextBoxText = "";
            this.SelectedFiles = new List<string>();
            this.ButtonText = "...";
        }

        public FileSelectionTextBoxVM(string defaultTextBoxText)
        {
            this.DefaultTextBoxText = defaultTextBoxText;
            this.SelectedFiles = new List<string>();
            this.ButtonText = "...";
        }

        public FileSelectionTextBoxVM(List<string> selectedFiles)
        {
            this.DefaultTextBoxText = "";
            this.SelectedFiles = selectedFiles;
            this.ButtonText = "...";
        }

        public FileSelectionTextBoxVM(string defaultTextBoxText, List<string> selectedFiles)
        {
            this.DefaultTextBoxText = defaultTextBoxText;
            this.SelectedFiles = selectedFiles;
            this.ButtonText = "...";
        }
    }
}
