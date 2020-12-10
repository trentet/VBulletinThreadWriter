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
    /// Interaction logic for WorldItemsField.xaml
    /// </summary>
    public partial class WorldItemsField : UserControl
    {
        public WorldItemsField()
        {
            InitializeComponent();
        }
    }

    public class WorldItemsFieldVM
    {
        public ScriptExampleModel ScriptExample { get; set; }
        public string Description
        {
            get => ScriptExample.WorldItemsSection.Description;
            set => ScriptExample.WorldItemsSection.Description = value;
        }

        //public List<WorldItemFieldVM> WorldItemFieldVMs
        //{
        //    get => ScriptExample.WorldItemsSection.WorldItems. != null ? ScriptExample.WorldItemsSection.Image.LocalPath : "";
        //    set => ScriptExample.WorldItemsSection.Image = new Uri(value);
        //}

        public WorldItemsFieldVM(ScriptExampleModel scriptExample)
        {
            this.ScriptExample = scriptExample;
        }

        public WorldItemsFieldVM()
        {
            
        }
    }
}
