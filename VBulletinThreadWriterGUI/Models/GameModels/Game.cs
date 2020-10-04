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
        public string Title { get; set; }
        public List<Skill> Skills { get; set; }

        public Game()
        {

        }
        
        public Game(string title, List<Skill> skills)
        {
            this.Title = title;
            this.Skills = skills;
        }
    }
}
