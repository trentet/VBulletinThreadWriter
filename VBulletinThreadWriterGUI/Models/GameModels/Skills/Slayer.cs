using System;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Slayer : Skill
    {
        public Slayer() :
            base(
                OSRSSkills.SLAYER,
                new Uri("https://i.imgur.com/dO51ekl.png"),
                SupportTypes.UNKNOWN_SUPPORT
            )
        {

        }
    }
}
