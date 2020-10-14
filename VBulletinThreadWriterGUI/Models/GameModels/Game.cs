using System.Collections.Generic;
using System.ComponentModel;

namespace VBulletinThreadWriterGUI.Models.GameModels
{
    public enum Games 
    { 
        [Description("OSRS")]
        OSRS,
        [Description("RS3")]
        RS3
    }

    public class Game
    {
        public Games EnumValue { get; private set; }
        public string Title { get; set; }
        public List<Skill> Skills { get; set; }

        public Game(Games enumValue)
        {
            this.EnumValue = enumValue;
            this.Title = this.EnumValue.ToDescription();
        }
        
        public Game(Games enumValue, List<Skill> skills)
        {
            this.EnumValue = enumValue;
            this.Title = this.EnumValue.ToDescription();
            this.Skills = skills;
        }
    }
}
