using System;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Woodcutting : Skill
    {
        public Woodcutting() :
            base(
                OSRSSkills.WOODCUTTING,
                new Uri("https://i.imgur.com/pBBoLBp.png"),
                SupportTypes.LIMITED_SUPPORT
            )
        {
            this.TrainingMethods.Add(
                "Regular trees",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Oak trees",
                SupportTypes.LIMITED_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Willow trees",
                SupportTypes.LIMITED_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Teak trees",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Sulliuscep",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Redwood trees",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );
        }
    }
}
