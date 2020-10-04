#nullable enable

using System;
using System.Collections.Generic;

namespace VBulletinThreadWriterGUI.Models.GameModels
{
    public class Skill
    {
        public string Name { get; set; }
        public SupportTypes? SupportType { get; set; }
        public List<TrainingMethodModel> TrainingMethods { get; set; }
        public List<Uri> SkillCapes { get; set; }

        public Skill()
        {
            this.Name = "";
            this.SkillCapes = new List<Uri>();
            this.SupportType = null;
            this.TrainingMethods = new List<TrainingMethodModel>();
        }

        public Skill(string name, List<Uri> skillCapes)
        {
            this.Name = name;
            this.SkillCapes = skillCapes;
            this.SupportType = null;
            this.TrainingMethods = new List<TrainingMethodModel>();
        }

        public Skill(string name, Uri skillCape)
        {
            this.Name = name;
            this.SkillCapes = new List<Uri> { skillCape };
            this.SupportType = null;
            this.TrainingMethods = new List<TrainingMethodModel>();
        }

        public Skill(string name, List<Uri> skillCapes, SupportTypes supportType)
        {
            this.Name = name;
            this.SkillCapes = skillCapes;
            this.SupportType = supportType;
            this.TrainingMethods = new List<TrainingMethodModel>();
        }

        public Skill(string name, Uri skillCape, SupportTypes supportType)
        {
            this.Name = name;
            this.SkillCapes = new List<Uri> { skillCape };
            this.SupportType = supportType;
            this.TrainingMethods = new List<TrainingMethodModel>();
        }

        public Skill(string name, List<Uri> skillCapes, SupportTypes supportType, List<TrainingMethodModel> trainingMethods)
        {
            this.Name = name;
            this.SkillCapes = skillCapes;
            this.SupportType = supportType;
            this.TrainingMethods = trainingMethods;
        }

        public Skill(string name, Uri skillCape, SupportTypes supportType, List<TrainingMethodModel> trainingMethods)
        {
            this.Name = name;
            this.SkillCapes = new List<Uri> { skillCape };
            this.SupportType = supportType;
            this.TrainingMethods = trainingMethods;
        }

        public Skill(string name, List<Uri> skillCapes, SupportTypes supportType, TrainingMethodModel trainingMethod)
        {
            this.Name = name;
            this.SkillCapes = skillCapes;
            this.SupportType = supportType;
            this.TrainingMethods = new List<TrainingMethodModel> { trainingMethod };
        }

        public Skill(string name, Uri skillCape, SupportTypes supportType, TrainingMethodModel trainingMethod)
        {
            this.Name = name;
            this.SkillCapes = new List<Uri> { skillCape };
            this.SupportType = supportType;
            this.TrainingMethods = new List<TrainingMethodModel> { trainingMethod };
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
