using System;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Ranged : Skill
    {
        public Ranged() :
            base(
                OSRSSkills.RANGED,
                new Uri("https://i.imgur.com/1rWs5hR.png"),
                SupportTypes.LIMITED_SUPPORT
            )
        {
            this.TrainingMethods.Add(
                "Crabs",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Cannoning Caged Ogres",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Cannoning Ice Trolls",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Cannoning Dagannoth under the Lighthouse",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );
        }
    }
}
