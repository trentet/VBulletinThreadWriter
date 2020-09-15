#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBulletinThreadWriterGUI
{
    public class Skill
    {
        public string Name { get; set; }
        public SupportTypes? SupportType { get; set; }
        public List<TrainingMethod>? TrainingMethods { get; set; }
        public List<Uri> SkillCapes { get; set; }

        public Skill()
        {
            this.Name = "";
            this.SkillCapes = new List<Uri>();
            this.SupportType = null;
            this.TrainingMethods = new List<TrainingMethod>();
        }

        public Skill(string name, List<Uri> skillCapes)
        {
            this.Name = name;
            this.SkillCapes = skillCapes;
            this.SupportType = null;
            this.TrainingMethods = null;
        }

        public Skill(string name, Uri skillCape)
        {
            this.Name = name;
            this.SkillCapes = new List<Uri> { skillCape };
            this.SupportType = null;
            this.TrainingMethods = null;
        }

        public Skill(string name, List<Uri> skillCapes, SupportTypes supportType)
        {
            this.Name = name;
            this.SkillCapes = skillCapes;
            this.SupportType = supportType;
            this.TrainingMethods = new List<TrainingMethod>();
        }

        public Skill(string name, Uri skillCape, SupportTypes supportType)
        {
            this.Name = name;
            this.SkillCapes = new List<Uri> { skillCape };
            this.SupportType = supportType;
            this.TrainingMethods = new List<TrainingMethod>();
        }

        public Skill(string name, List<Uri> skillCapes, SupportTypes supportType, List<TrainingMethod> trainingMethods)
        {
            this.Name = name;
            this.SkillCapes = skillCapes;
            this.SupportType = supportType;
            this.TrainingMethods = trainingMethods;
        }

        public Skill(string name, Uri skillCape, SupportTypes supportType, List<TrainingMethod> trainingMethods)
        {
            this.Name = name;
            this.SkillCapes = new List<Uri> { skillCape };
            this.SupportType = supportType;
            this.TrainingMethods = trainingMethods;
        }

        public Skill(string name, List<Uri> skillCapes, SupportTypes supportType, TrainingMethod trainingMethod)
        {
            this.Name = name;
            this.SkillCapes = skillCapes;
            this.SupportType = supportType;
            this.TrainingMethods = new List<TrainingMethod> { trainingMethod };
        }

        public Skill(string name, Uri skillCape, SupportTypes supportType, TrainingMethod trainingMethod)
        {
            this.Name = name;
            this.SkillCapes = new List<Uri> { skillCape };
            this.SupportType = supportType;
            this.TrainingMethods = new List<TrainingMethod> { trainingMethod };
        }
    }

    public enum SupportTypes
    {
        UNKNOWN_SUPPORT,
        SUPPORTED,
        UNSUPPORTED,
        LIMITED_SUPPORT,
        VERY_LIMITED_SUPPORT
    }
}
