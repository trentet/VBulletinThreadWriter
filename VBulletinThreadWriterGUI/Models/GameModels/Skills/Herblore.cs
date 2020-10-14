using System;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Herblore : Skill
    {
        public Herblore() :
            base(
                Games.OSRS,
                OSRSSkills.OSRSSkillNames.HERBLORE.ToDescription(),
                new Uri("https://i.imgur.com/oobLfZY.png"),
                SupportTypes.SUPPORTED
            )
        {
            this.TrainingMethods.Add(
                "Making Potions",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Making Tar",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Herb Cleaning",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );
        }
    }
}
