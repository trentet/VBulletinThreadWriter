using System;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Woodcutting : Skill
    {
        public Woodcutting() :
            base(
                OSRSSkills.OSRSSkillNames.WOODCUTTING.ToDescription(),
                new Uri("https://i.imgur.com/pBBoLBp.png"),
                SupportTypes.LIMITED_SUPPORT
            )
        {
            this.TrainingMethods.Add(
                "Regular trees",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Oak trees",
                SupportTypes.LIMITED_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Willow trees",
                SupportTypes.LIMITED_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Teak trees",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Sulliuscep",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Redwood trees",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );
        }
    }
}
