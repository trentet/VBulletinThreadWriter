using System;
using System.Collections.Generic;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Farming : Skill
    {
        public Farming() :
            base(
                OSRSSkills.OSRSSkillNames.FARMING.ToDescription(),
                new List<Uri> { new Uri("https://i.imgur.com/e4sqLSj.png") },
                SupportTypes.UNSUPPORTED
            )
        {
            this.TrainingMethods.Add(
                "Tree runs",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Herb Runs",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );
        }
    }
}
