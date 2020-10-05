using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.Fields
{
    /// <summary>
    /// Interaction logic for VisionSystemField.xaml
    /// </summary>
    public partial class VisionSystemField : UserControl
    {
        public VisionSystemField()
        {
            InitializeComponent();
        }
    }

    public class VisionSystemFieldVM
    {
        public ScriptExampleModel ScriptExample { get; set; }
        public string Text 
        { 
            get => ScriptExample == null ? "" : (ScriptExample.VisionSystem != null ? ScriptExample.VisionSystem.ToDescription() : ""); 
            set => ScriptExample.VisionSystem = 
                new List<VisionSystems> 
                { 
                    VisionSystems.COLOR, 
                    VisionSystems.SHAPE 
                }
                .Where(o => o.ToDescription().Equals(value)).First(); }

        public VisionSystemFieldVM(ScriptExampleModel scriptExample)
        {
            this.ScriptExample = scriptExample;
        }
    }
}
