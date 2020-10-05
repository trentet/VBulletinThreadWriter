using System;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Firemaking : Skill
    {
        public Firemaking() :
            base(
                OSRSSkills.OSRSSkillNames.FIREMAKING.ToDescription(),
                new Uri("https://i.imgur.com/e4sqLSj.png"),
                SupportTypes.UNSUPPORTED
            )
        {
            this.TrainingMethods.Add(
                "Burning Logs",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Wintertodt",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );
        }
    }
}
