using System;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Fishing : Skill
    {
        public Fishing() :
            base(
                OSRSSkills.FISHING,
                new Uri("https://i.imgur.com/H4NQkul.png"),
                SupportTypes.VERY_LIMITED_SUPPORT
            )
        {
            this.TrainingMethods.Add(
                "Fly Fishing",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Drift Net Fishing",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Barbarian Fishing",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "2-Tick Harpooning Swordfish/Tuna",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Aerial Fishing",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Monkfish",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Karambwan",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Swordfish/Tuna",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Infernal Eel",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Minnow",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Anglerfish",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Dark Crabs",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Sacred Eel",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );
        }
    }
}
