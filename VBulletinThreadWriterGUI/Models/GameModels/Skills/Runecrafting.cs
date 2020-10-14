using System;
using System.Collections.Generic;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Runecrafting : Skill
    {
        public Runecrafting() :
            base(
                Games.OSRS,
                OSRSSkills.OSRSSkillNames.RUNECRAFTING.ToDescription(),
                new List<Uri> { new Uri("https://i.imgur.com/tE9I9h8.png") },
                SupportTypes.UNKNOWN_SUPPORT
            )
        {
            this.TrainingMethods.Add(
                "Crafting Tiaras",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Air Runes",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Earth Runes",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Fire Runes",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Smoke Runes",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Steam Runes",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Lava Runes",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Ourania Altar",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Blood Runes",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Soul Runes",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Abyss",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Daeyalt Essences",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Double Cosmic Runes",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Double Astral Runes",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Double Nature Runes",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Double Law Runes",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Wrath runes",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );
        }
    }
}
