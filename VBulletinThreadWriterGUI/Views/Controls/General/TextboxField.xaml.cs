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


        public TextBoxField()
        {
            InitializeComponent();
        }
    }
}
