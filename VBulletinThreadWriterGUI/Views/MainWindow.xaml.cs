#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models;
using VBulletinThreadWriterGUI.Models.GameModels;
using VBulletinThreadWriterGUI.Views.Controls.General;
using VBulletinThreadWriterGUI.Views.Controls.MainWindow;

namespace VBulletinThreadWriterGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindowVM MainWindowViewModel = new MainWindowVM();
        public MainWindow()
        {
            InitializeComponent();
            this.MainWindowViewControl.ViewModel = MainWindowViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TrainingMethodWindow trainingMethodWindow = 
                new TrainingMethodWindow(MainWindowViewModel.TrainingMethodFieldViewModel.SelectedTrainingMethod);
            trainingMethodWindow.Show();
        }
    }
}
