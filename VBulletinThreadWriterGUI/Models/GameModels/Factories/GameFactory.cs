using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBulletinThreadWriterGUI.Models.GameModels.Factories
{
    public static class GameFactory
    {
        public static List<Game> GetGames()
        {
            List<Game> games = new List<Game> { GetGame(Games.OSRS) };
            return games;
        }

        public static Game GetGame(Games game)
        {
            switch (game)
            {
                case Games.OSRS:
                    return new OSRS();
                case Games.RS3:
                    throw new NotImplementedException("RS3 has not been implemented. ");
            }
            return null;
        }
    }
}
