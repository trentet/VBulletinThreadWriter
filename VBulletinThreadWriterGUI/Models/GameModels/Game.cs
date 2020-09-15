using System.Collections.Generic;

namespace VBulletinThreadWriterGUI.Models.GameModels
{
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
