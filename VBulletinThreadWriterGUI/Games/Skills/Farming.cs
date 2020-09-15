using System;

namespace VBulletinThreadWriterGUI.Games.OSRS.Skills
{
    public class Farming : Skill
    {
        public Farming() :
            base(
                OSRSSkills.FARMING,
                new Uri("https://i.imgur.com/e4sqLSj.png"),
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
