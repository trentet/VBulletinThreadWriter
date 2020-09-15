using System.Collections.Generic;
using VBulletinThreadWriterGUI.Models.GameModels;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Models
{
    public class TrainingMethodModel
    {
        public string Name { get; set; }
        public SupportTypes? SupportType { get; set; }
        public ScriptExample ScriptExample { get; set; }

        public TrainingMethodModel()
        {
            this.Name = "";
            this.SupportType = null;
            this.ScriptExample = null;
        }

        public TrainingMethodModel(string name)
        {
            this.Name = name;
            this.SupportType = null;
            this.ScriptExample = null;
        }

        public TrainingMethodModel(string name, SupportTypes supportType)
        {
            this.Name = name;
            this.SupportType = supportType;
            this.ScriptExample = null;
        }

        public TrainingMethodModel(string name, SupportTypes supportType, ScriptExample scriptExample)
        {
            this.Name = name;
            this.SupportType = supportType;
            this.ScriptExample = scriptExample;
        }
    }

    public static class TrainingMethodExtensions
    {
        public static void Add(
            this List<TrainingMethodModel> trainingMethods, 
            string name, 
            SupportTypes supportType, 
            ScriptExample scriptExample
        )
        {
            trainingMethods.Add(new TrainingMethodModel(name, supportType, scriptExample));
        }
    }
}
