using System.Windows;
using VBulletinThreadWriterGUI.Models;
using VBulletinThreadWriterGUI.Views.Controls.TrainingMethod;
using VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample;
using VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.Fields;

namespace VBulletinThreadWriterGUI
{
    /// <summary>
    /// Interaction logic for TrainingMethodWindow.xaml
    /// </summary>
    public partial class TrainingMethodWindow : Window
    {
        public static TrainingMethodModel TrainingMethodModel { get; set; }
        
        public static NameFieldVM NameFieldViewModel = new NameFieldVM(TrainingMethodModel);

        public static ScriptExampleVM ScriptExampleViewModel = new ScriptExampleVM(TrainingMethodModel.ScriptExample);
        
        public TrainingMethodWindow()
        {
            InitializeComponent();
        }
    }
}
