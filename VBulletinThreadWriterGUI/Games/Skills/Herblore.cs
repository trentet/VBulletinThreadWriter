using System;

namespace VBulletinThreadWriterGUI.Games.OSRS.Skills
{
    public class Herblore : Skill
    {
        public Herblore() :
            base(
                OSRSSkills.HERBLORE,
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
