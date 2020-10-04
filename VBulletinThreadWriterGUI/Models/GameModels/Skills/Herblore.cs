using System;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Herblore : Skill
    {
        public Herblore() :
            base(
                OSRSSkills.OSRSSkillNames.HERBLORE.ToDescription(),
                new Uri("https://i.imgur.com/oobLfZY.png"),
                SupportTypes.SUPPORTED
            )
        {
            this.TrainingMethods.Add(
                "Making Potions",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Making Tar",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Herb Cleaning",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );
        }
    }
}
