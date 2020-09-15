using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBulletinThreadWriterGUI
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
