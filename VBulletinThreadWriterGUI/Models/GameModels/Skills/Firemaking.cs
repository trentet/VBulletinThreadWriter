using System;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Firemaking : Skill
    {
        public Firemaking() :
            base(
                OSRSSkills.FIREMAKING,
                new Uri("https://i.imgur.com/e4sqLSj.png"),
                SupportTypes.UNSUPPORTED
            )
        {
            this.TrainingMethods.Add(
                "Burning Logs",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Wintertodt",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );
        }
    }
}
