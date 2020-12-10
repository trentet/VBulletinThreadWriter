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

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.ViewFields
{
    /// <summary>
    /// Interaction logic for InterfaceItemsField.xaml
    /// </summary>
    public partial class InterfaceItemsField : UserControl
    {
        public InterfaceItemsField()
        {
            InitializeComponent();
        }
    }

    public class InterfaceItemsFieldVM
    {
        public ScriptExampleModel ScriptExample { get; set; }
        public string Description
        {
            get => ScriptExample.InterfaceItemsSection.Description;
            set => ScriptExample.InterfaceItemsSection.Description = value;
        }

        //public List<InterfaceItemFieldVM> InterfaceItemFieldVMs
        //{
        //    get => ScriptExample.InterfaceItemsSection.InterfaceItems. != null ? ScriptExample.InterfaceItemsSection.Image.LocalPath : "";
        //    set => ScriptExample.InterfaceItemsSection.Image = new Uri(value);
        //}

        public InterfaceItemsFieldVM(ScriptExampleModel scriptExample)
        {
            this.ScriptExample = scriptExample;
        }

        public InterfaceItemsFieldVM()
        {
            
        }
    }
}
