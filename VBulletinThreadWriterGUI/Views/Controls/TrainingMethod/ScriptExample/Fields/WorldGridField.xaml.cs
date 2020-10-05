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
    /// Interaction logic for WorldGridField.xaml
    /// </summary>
    public partial class WorldGridField : UserControl
    {
        public WorldGridField()
        {
            InitializeComponent();
        }
    }

    public class WorldGridFieldVM
    {
        public ScriptExampleModel ScriptExample { get; set; }
        public string Description 
        { 
            get => ScriptExample.WorldGridSection.Description; 
            set => ScriptExample.WorldGridSection.Description = value; 
        }
        
        public string Image 
        { 
            get => ScriptExample.WorldGridSection.Image != null ? ScriptExample.WorldGridSection.Image.LocalPath : ""; 
            set => ScriptExample.WorldGridSection.Image = new Uri(value); 
        }

        public WorldGridFieldVM(ScriptExampleModel scriptExample)
        {
            this.ScriptExample = scriptExample;
        }
    }
}
