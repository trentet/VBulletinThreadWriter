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
    /// Interaction logic for MapField.xaml
    /// </summary>
    public partial class MapField : UserControl
    {
        public MapField()
        {
            InitializeComponent();
        }
    }

    public class MapFieldVM
    {
        public ScriptExampleModel ScriptExample { get; set; }
        public string Description
        {
            get => ScriptExample.MapSection.Description;
            set => ScriptExample.MapSection.Description = value;
        }

        public string Image
        {
            get => ScriptExample.MapSection.Image != null ? ScriptExample.MapSection.Image.LocalPath : "";
            set => ScriptExample.MapSection.Image = new Uri(value);
        }

        public MapFieldVM(ScriptExampleModel scriptExample)
        {
            this.ScriptExample = scriptExample;
        }
    }
}
