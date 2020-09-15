using System;
using System.Collections.Generic;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Melee : Skill
    {
        public Melee() : 
            base(
                "Melee", 
                new List<Uri> 
                { 
                    new Uri("https://i.imgur.com/OhEiD7d.png"), //Attack
                    new Uri("https://i.imgur.com/OhEiD7d.png"), //Strength
                    new Uri("https://i.imgur.com/OhEiD7d.png") //Defence
                }, 
                SupportTypes.LIMITED_SUPPORT
            )
        {
            this.TrainingMethods.Add(
                "Chicken",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Men and Women",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Al-Kharid warrior",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Chaos druid",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Moss Giant",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Ammonite Crab",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Sand Crab",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Rock Crab",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Experiment",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Nightmare Zone",
                SupportTypes.LIMITED_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Green Dragon",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Gargoyle",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Rune Dragon",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Yak",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Monkey Guards",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Pest Control",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );
        }
    }
}
