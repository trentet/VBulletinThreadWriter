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

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.ViewFields{
    /// <summary>
    /// Interaction logic for WorldItemField.xaml
    /// </summary>
    public partial class WorldItemField : UserControl
    {
        public WorldItemField()
        {
            InitializeComponent();
        }
    }

    public class WorldItemFieldVM
    {
        public WorldItem WorldItem { get; set; }
        public string Description
        {
            get => WorldItem.Description;
            set => WorldItem.Description = value;
        }

        public string Image
        {
            get => WorldItem.Image != null ? WorldItem.Image.LocalPath : "";
            set => WorldItem.Image = new Uri(value);
        }
    }
}
