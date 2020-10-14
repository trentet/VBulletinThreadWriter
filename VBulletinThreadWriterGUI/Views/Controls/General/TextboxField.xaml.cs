using System.Windows;
using System.Windows.Controls;

namespace VBulletinThreadWriterGUI.Views.Controls.General
{
    /// <summary>
    /// Interaction logic for TextBoxField.xaml
    /// </summary>
    public partial class TextBoxField : UserControl
    {
        public static readonly DependencyProperty FieldNameProperty
            = DependencyProperty.Register(
                  "FieldName",
                  typeof(string),
                  typeof(TextBoxField),
                  new PropertyMetadata("")
              );

        public string FieldName
        {
            get { return (string)GetValue(FieldNameProperty); }
            set { SetValue(FieldNameProperty, value); }
        }

        public static readonly DependencyProperty FieldHeightProperty
            = DependencyProperty.Register(
                  "FieldHeight",
                  typeof(int),
                  typeof(TextBoxField),
                  new PropertyMetadata(0)
              );

        public int FieldHeight
        {
            get { return (int)GetValue(FieldHeightProperty); }
            set { SetValue(FieldHeightProperty, value); }
        }

        public static readonly DependencyProperty FieldTextBoxWidthProperty
            = DependencyProperty.Register(
                  "FieldTextBoxWidth",
                  typeof(int),
                  typeof(TextBoxField),
                  new PropertyMetadata(0)
             );

        public int FieldTextBoxWidth
        {
            get { return (int)GetValue(FieldTextBoxWidthProperty); }
            set { SetValue(FieldTextBoxWidthProperty, value); }
        }

        public static readonly DependencyProperty FieldTextProperty
            = DependencyProperty.Register(
                  "FieldText",
                  typeof(string),
                  typeof(TextBoxField),
                  new PropertyMetadata("")
             );

        public string FieldText
        {
            get { return (string)GetValue(FieldTextProperty); }
            set { SetValue(FieldTextProperty, value); }
        }

        /* View Model Property */

        public static readonly DependencyProperty ViewModelProperty
            = DependencyProperty.Register(
                  "ViewModel",
                  typeof(TextBoxFieldVM),
                  typeof(TextBoxField),
                  new PropertyMetadata(new TextBoxFieldVM())
             );
        public TextBoxFieldVM ViewModel
        {
            get { return (TextBoxFieldVM)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); this.FieldTextBox.DataContext = ViewModel; }
        }

        public TextBoxField()
        {
            InitializeComponent();
            this.FieldTextBox.DataContextChanged += TextBox_DataContextChanged;
            //if (this.FieldTextBoxChanged == null)
            //{
            //    FieldTextBoxChanged += TextBox_Changed;
            //}
        }

        public void TextBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            LoadLabel(this.FieldLabel);
            LoadTextBox(this.FieldTextBox);
        }

        public void Label_Loaded(object sender, RoutedEventArgs e)
        {
            LoadLabel(sender as Label);
        }

        public void LoadLabel(Label label)
        {
            label.Content = ViewModel.LabelName;
        }

        public void TextBox_Loaded(object sender, RoutedEventArgs e)
        {
            LoadTextBox(sender as TextBox);
        }

        public void LoadTextBox(TextBox TextBox)
        {
            TextBox.Text = ViewModel.Text;
        }
    }

    public class TextBoxFieldVM
    {
        public string LabelName { get; set; }
        public string Text { get; set; }

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
}
