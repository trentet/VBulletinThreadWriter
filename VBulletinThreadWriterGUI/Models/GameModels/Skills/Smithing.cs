using System;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Smithing : Skill
    {
        public Smithing() :
            base(
                OSRSSkills.OSRSSkillNames.SMITHING.ToDescription(),
                new Uri("https://i.imgur.com/mr9zT2G.png"),
                SupportTypes.LIMITED_SUPPORT
            )
        {
            this.TrainingMethods.Add(
                "Anvil smithing",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Gold bars (Blast Furnace)",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Blast Furnace",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Smithing dart tips",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Smithing armour",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Smithing 3-bar rune items",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );
        }
    }
}
