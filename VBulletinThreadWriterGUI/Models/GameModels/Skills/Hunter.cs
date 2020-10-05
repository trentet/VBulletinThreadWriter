using System;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Hunter : Skill
    {
        public Hunter() :
            base(
                OSRSSkills.OSRSSkillNames.HUNTER.ToDescription(),
                new Uri("https://i.imgur.com/oiO9Q3p.png"),
                SupportTypes.UNSUPPORTED
            )
        {
            this.TrainingMethods.Add(
                "Bird House Trapping",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Feldip Weasels",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Sandworms",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Ruby Harvests + Copper Longtails",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Swamp Lizards",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Falconry",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Red Salamanders",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Black Salamanders",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Black Chinchompas",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Crimson Swifts",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Copper Longtails",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Cerulean Twitches",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Ferrets",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Tropical Wagtails",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Aerial Fishing",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Prickly Kebbits",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Orange Salamanders",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Maniacal Monkeys",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Carnivorous Chinchompas",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            this.TrainingMethods.Add(
                "Herbiboars",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );
        }
    }
}
