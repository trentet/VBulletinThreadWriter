using System;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Mining : Skill
    {
        public Mining() :
            base(
                OSRSSkills.OSRSSkillNames.MINING.ToDescription(),
                new Uri("https://i.imgur.com/A1TyNpR.png"),
                SupportTypes.LIMITED_SUPPORT
            )
        {
            this.TrainingMethods.Add(
                "Powermining Iron Ore",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Powermining Granite",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Motherload Mode",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Powermining Gem Rocks",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Volcanic Mine",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Blast Mine",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Powermining Amethyst",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );
        }
    }
}
