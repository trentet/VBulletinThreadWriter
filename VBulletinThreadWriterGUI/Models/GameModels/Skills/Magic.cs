using System;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Magic : Skill
    {
        public Magic() :
            base(
                Games.OSRS,
                OSRSSkills.OSRSSkillNames.MAGIC.ToDescription(),
                new Uri("https://i.imgur.com/5lOVU3p.png"),
                SupportTypes.SUPPORTED
            )
        {
            this.TrainingMethods.Add(
                "Superheat",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Camelot Teleport",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "High Alchemy",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Magic Imbue",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Enchant Crossbow Bolts",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Enchant Jewelery",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Tele-alching",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Charging Orbs",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Tan Leather",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Stun-alching",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "String Jewelry",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Plank Make",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Superglass Make",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );
        }
    }
}
