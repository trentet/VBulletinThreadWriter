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
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.Fields{
    /// <summary>
    /// Interaction logic for InterfaceItemsField.xaml
    /// </summary>
    public partial class InterfaceItemField : UserControl
    {
        public InterfaceItemField()
        {
            InitializeComponent();
        }
    }

    public class InterfaceItemFieldVM
    {
        public InterfaceItem InterfaceItem { get; set; }
        public string Description
        {
            get => InterfaceItem.Description;
            set => InterfaceItem.Description = value;
        }

        public string Image
        {
            get => InterfaceItem.Image != null ? InterfaceItem.Image.LocalPath : "";
            set => InterfaceItem.Image = new Uri(value);
        }
    }
}