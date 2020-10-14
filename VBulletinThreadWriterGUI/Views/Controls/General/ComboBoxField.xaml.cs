using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace VBulletinThreadWriterGUI.Views.Controls.General
{
    //public interface I


    /// <summary>
    /// Interaction logic for ComboBoxField.xaml
    /// </summary>
    public partial class ComboBoxField : UserControl, IComboBoxField
    {
        /* Start of Custom Properties */

        /* Field Height Property */

        public static readonly DependencyProperty FieldHeightProperty
            = DependencyProperty.Register(
                  "FieldHeight",
                  typeof(int),
                  typeof(ComboBoxField),
                  new PropertyMetadata(0)
              );

        public int FieldHeight
        {
            get { return (int)GetValue(FieldHeightProperty); }
            set { SetValue(FieldHeightProperty, value); }
        }

        /* Field ComboBox Width Property */

        public static readonly DependencyProperty FieldComboBoxWidthProperty
            = DependencyProperty.Register(
                  "FieldComboBoxWidth",
                  typeof(int),
                  typeof(ComboBoxField),
                  new PropertyMetadata(0)
             );

        public int FieldComboBoxWidth
        {
            get { return (int)GetValue(FieldComboBoxWidthProperty); }
            set { SetValue(FieldComboBoxWidthProperty, value); }
        }

        /* Field Name Property */

        public static readonly DependencyProperty FieldNameProperty
            = DependencyProperty.Register(
                  "FieldName",
                  typeof(string),
                  typeof(ComboBoxField),
                  new PropertyMetadata("")
             );

        public string FieldName
        {
            get { return (string)GetValue(FieldNameProperty); }
            set { SetValue(FieldNameProperty, value); }
        }

        /* View Model Property */

        public static readonly DependencyProperty ViewModelProperty
            = DependencyProperty.Register(
                  "ViewModel",
                  typeof(ComboBoxFieldVM),
                  typeof(ComboBoxField),
                  new PropertyMetadata(new ComboBoxFieldVM())
             );

        public ComboBoxFieldVM ViewModel
        {
            get { return (ComboBoxFieldVM)GetValue(ViewModelProperty); }
            set 
            { 
                SetValue(ViewModelProperty, value); 
                this.FieldComboBox.DataContext = ViewModel; 
            }
        }

        /* SelectionChanged Property */

        public static readonly DependencyProperty FieldComboBoxSelectionChangedProperty
            = DependencyProperty.Register(
                  "FieldComboBoxSelectionChanged",
                  typeof(SelectionChangedEventHandler),
                  typeof(ComboBoxField),
                  new PropertyMetadata(null)
             );

        public SelectionChangedEventHandler FieldComboBoxSelectionChanged
        {
            get { return (SelectionChangedEventHandler)GetValue(FieldComboBoxSelectionChangedProperty); }
            set { SetValue(FieldComboBoxSelectionChangedProperty, value); this.FieldComboBox.SelectionChanged += FieldComboBoxSelectionChanged; }
        }

        /* DataContextChanged Property */

        public static readonly DependencyProperty FieldDataContextChangedProperty
            = DependencyProperty.Register(
                  "FieldDataContextChanged",
                  typeof(DependencyPropertyChangedEventHandler),
                  typeof(ComboBoxField),
                  new PropertyMetadata(null)
             );

        public DependencyPropertyChangedEventHandler FieldDataContextChanged
        {
            get { return (DependencyPropertyChangedEventHandler)GetValue(FieldDataContextChangedProperty); }
            set { SetValue(FieldDataContextChangedProperty, value); this.FieldComboBox.DataContextChanged += FieldDataContextChanged; }
        }

        IComboBoxFieldVM IComboBoxField.ViewModel { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        /* End of Custom Properties */

        public ComboBoxField()
        {
            InitializeComponent();
            this.FieldComboBox.DataContextChanged += ComboBox_DataContextChanged;
            if(this.FieldComboBoxSelectionChanged == null)
            {
                FieldComboBoxSelectionChanged += ComboBox_SelectionChanged;
            }
        }

        public void ComboBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            LoadLabel(this.FieldLabel);
            LoadComboBox(this.FieldComboBox);
        }

        public void Label_Loaded(object sender, RoutedEventArgs e)
        {
            LoadLabel(sender as Label);
        }

        public void LoadLabel(Label label)
        {
            label.Content = ViewModel.LabelName;
        }

        public void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            LoadComboBox(sender as ComboBox);
        }

        public void LoadComboBox(ComboBox comboBox)
        {
            comboBox.ItemsSource = ViewModel.ItemsSource;

            // ... Make the first item selected.
            comboBox.SelectedIndex = 0;
        }

        public void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... Get the ComboBox.
            var comboBox = sender as ComboBox;

            // ... Set SelectedItem as Window Title.
            ViewModel.SelectedItem = comboBox.SelectedItem as string;
        }
    }

    public class ComboBoxFieldVM : IComboBoxFieldVM
    {
        public string LabelName { get; set; }
        public string SelectedItem { get; set; }
        public List<string> ItemsSource { get; set; }

        public ComboBoxFieldVM()
        {
            this.LabelName = "";
            this.ItemsSource = new List<string>();
            this.SelectedItem = "";
        }

        public ComboBoxFieldVM(
            string labelName, 
            string selectedItem, 
            List<string> itemsSource
        )
        {
            this.LabelName = labelName;
            this.ItemsSource = itemsSource;
            this.SelectedItem = selectedItem;
        }
    }

    public interface IComboBoxFieldVM
    {
        string LabelName { get; set; }
        string SelectedItem { get; set; }
        List<string> ItemsSource { get; set; }
    }

    public interface IComboBoxField
    {
        public int FieldHeight { get; set; }
        public int FieldComboBoxWidth { get; set; }
        public string FieldName { get; set; }
        public IComboBoxFieldVM ViewModel { get; set; }
        public void ComboBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e);
        public void Label_Loaded(object sender, RoutedEventArgs e);
        public void LoadLabel(Label label);
        public void ComboBox_Loaded(object sender, RoutedEventArgs e);
        public void LoadComboBox(ComboBox comboBox);
        public void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e);
    }
}
