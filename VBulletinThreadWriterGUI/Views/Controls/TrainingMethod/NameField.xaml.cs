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
using VBulletinThreadWriterGUI.Models;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod
{
    /// <summary>
    /// Interaction logic for NameField.xaml
    /// </summary>
    public partial class NameField : UserControl
    {
        public NameField()
        {
            InitializeComponent();
        }
    }

    public class NameFieldVM
    {
        public TrainingMethodModel TrainingMethodModel { get; set; }
        public string Name { get => TrainingMethodModel.Name; set => TrainingMethodModel.Name = value; }

        public NameFieldVM(TrainingMethodModel trainingMethodModel)
        {
            this.TrainingMethodModel = trainingMethodModel;
        }
    }
}
