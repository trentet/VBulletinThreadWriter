#nullable enable

using System;
using System.Collections.Generic;

namespace VBulletinThreadWriterGUI.Models.GameModels
{
    public class Skill
    {
        public Games ParentGame { get; private set; }
        public string Name { get; set; }
        public SupportTypes? SupportType { get; set; }
        public List<TrainingMethodModel> TrainingMethods { get; set; }
        public List<Uri> SkillCapes { get; set; }

        public Skill(Games parentGame)
        {
            this.ParentGame = parentGame;
            this.Name = "";
            this.SkillCapes = new List<Uri>();
            this.SupportType = null;
            this.TrainingMethods = new List<TrainingMethodModel>();
        }

        public Skill(Games parentGame, string name, List<Uri> skillCapes)
        {
            this.ParentGame = parentGame;
            this.Name = name;
            this.SkillCapes = skillCapes;
            this.SupportType = null;
            this.TrainingMethods = new List<TrainingMethodModel>();
        }

        public Skill(Games parentGame, string name, Uri skillCape)
        {
            this.ParentGame = parentGame;
            this.Name = name;
            this.SkillCapes = new List<Uri> { skillCape };
            this.SupportType = null;
            this.TrainingMethods = new List<TrainingMethodModel>();
        }

        public Skill(Games parentGame, string name, List<Uri> skillCapes, SupportTypes supportType)
        {
            this.ParentGame = parentGame;
            this.Name = name;
            this.SkillCapes = skillCapes;
            this.SupportType = supportType;
            this.TrainingMethods = new List<TrainingMethodModel>();
        }

        public Skill(Games parentGame, string name, Uri skillCape, SupportTypes supportType)
        {
            this.ParentGame = parentGame;
            this.Name = name;
            this.SkillCapes = new List<Uri> { skillCape };
            this.SupportType = supportType;
            this.TrainingMethods = new List<TrainingMethodModel>();
        }

        public Skill(Games parentGame, string name, List<Uri> skillCapes, SupportTypes supportType, List<TrainingMethodModel> trainingMethods)
        {
            this.ParentGame = parentGame;
            this.Name = name;
            this.SkillCapes = skillCapes;
            this.SupportType = supportType;
            this.TrainingMethods = trainingMethods;
        }

        public Skill(Games parentGame, string name, Uri skillCape, SupportTypes supportType, List<TrainingMethodModel> trainingMethods)
        {
            this.ParentGame = parentGame;
            this.Name = name;
            this.SkillCapes = new List<Uri> { skillCape };
            this.SupportType = supportType;
            this.TrainingMethods = trainingMethods;
        }

        public Skill(Games parentGame, string name, List<Uri> skillCapes, SupportTypes supportType, TrainingMethodModel trainingMethod)
        {
            this.ParentGame = parentGame;
            this.Name = name;
            this.SkillCapes = skillCapes;
            this.SupportType = supportType;
            this.TrainingMethods = new List<TrainingMethodModel> { trainingMethod };
        }

        public Skill(Games parentGame, string name, Uri skillCape, SupportTypes supportType, TrainingMethodModel trainingMethod)
        {
            this.ParentGame = parentGame;
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
