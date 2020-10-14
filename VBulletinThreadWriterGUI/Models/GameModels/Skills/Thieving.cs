using System;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Thieving : Skill
    {
        public Thieving() :
            base(
                Games.OSRS,
                OSRSSkills.OSRSSkillNames.THIEVING.ToDescription(),
                new Uri("https://i.imgur.com/sv53tf1.png"),
                SupportTypes.VERY_LIMITED_SUPPORT
            )
        {
            this.TrainingMethods.Add(
                "Bakers' stall",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Fruit stalls",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Blackjacking Bearded Pollnivnian Bandits",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Blackjacking Pollnivnian Bandits",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Blackjacking Menaphite Thugs",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Stealing artefacts",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Pyramid Plunder",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Silk stalls",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Underwater",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Knights of Ardougne",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Dorgesh-Kaan Rich Chests",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Master Farmers",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Sorceress's Garden",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Pickpocketing Elves",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "TzHaar-Hur",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );
        }
    }
}
