using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBulletinThreadWriterGUI
{
    public class TrainingMethod
    {
        public string Name { get; set; }
        public SupportTypes? SupportType { get; set; }
        public ScriptExample ScriptExample { get; set; }

        public TrainingMethod()
        {
            this.Name = "";
            this.SupportType = null;
            this.ScriptExample = null;
        }

        public TrainingMethod(string name)
        {
            this.Name = name;
            this.SupportType = null;
            this.ScriptExample = null;
        }

        public TrainingMethod(string name, SupportTypes supportType)
        {
            this.Name = name;
            this.SupportType = supportType;
            this.ScriptExample = null;
        }

        public TrainingMethod(string name, SupportTypes supportType, ScriptExample scriptExample)
        {
            this.Name = name;
            this.SupportType = supportType;
            this.ScriptExample = scriptExample;
        }
    }

    public static class TrainingMethodExtensions
    {
        public static void Add(
            this List<TrainingMethod> trainingMethods, 
            string name, 
            SupportTypes supportType, 
            ScriptExample scriptExample
        )
        {
            trainingMethods.Add(new TrainingMethod(name, supportType, scriptExample));
        }
    }
}
