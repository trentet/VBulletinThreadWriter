using VBulletinThreadWriterGUI.ViewModels;
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

namespace VBulletinThreadWriterGUI
{
    /// <summary>
    /// Interaction logic for MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        //public static ReleaseFieldVM ReleaseFieldVM = new ReleaseFieldVM();
        public MainWindow2()
        {
            InitializeComponent();
            //this.ReleaseField.ViewModel = ReleaseFieldVM;
        }

        //private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        //{
        //    // ... Get the ComboBox reference.
        //    var comboBox = sender as ComboBox;

        //    // ... Assign the ItemsSource to the List.
        //    comboBox.ItemsSource = this.TestList;

        //    // ... Make the first item selected.
        //    comboBox.SelectedIndex = 0;
        //}

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    // ... Get the ComboBox.
        //    var comboBox = sender as ComboBox;

        //    // ... Set SelectedItem as Window Title.
        //    this.TestSelectedItem = comboBox.SelectedItem as string;
        //}
    }
}
