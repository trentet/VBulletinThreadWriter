using System;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Prayer : Skill
    {
        public Prayer() :
            base(
                OSRSSkills.PRAYER,
                new Uri("https://i.imgur.com/qeOvWWH.png"),
                SupportTypes.UNKNOWN_SUPPORT
            )
        {
            this.TrainingMethods.Add(
                "Gilded Altar",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Chaos Altar",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Reanimating Ensouled Heads",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );
        }
    }
}
