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
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.Fields{
    /// <summary>
    /// Interaction logic for CaveatsAndLimitationsField.xaml
    /// </summary>
    public partial class CaveatsAndLimitationsField : UserControl
    {
        public CaveatsAndLimitationsField()
        {
            InitializeComponent();
        }
    }

    public class CaveatsAndLimitationsFieldVM
    {
        public ScriptExampleModel ScriptExample { get; set; }
        public string Text { get => ScriptExample.CaveatsAndLimitations; set => ScriptExample.CaveatsAndLimitations = value; }

        public CaveatsAndLimitationsFieldVM(ScriptExampleModel scriptExample)
        {
            this.ScriptExample = scriptExample;
        }
    }
}
