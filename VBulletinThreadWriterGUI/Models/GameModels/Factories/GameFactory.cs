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

        public static List<Game> GetGames(List<Games> gameEnums)
        {
            List<Game> games = new List<Game>();
            foreach(Games gameEnum in gameEnums)
            {
                games.Add(GetGame(gameEnum));
            }
            return games;
        }

        public static List<Game> GetGames(IEnumerable<string> gamesAsText)
        {
            List<Games> gameEnums = Enum.GetValues(typeof(Games)).Cast<Games>().Where(o => gamesAsText.Contains(o.ToDescription())).ToList();

            List<Game> games = GetGames(gameEnums);

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

        public static Game GetGame(string gameText)
        {
            Game game = GetGames(new List<string>() { gameText }).First();

            return game;
        }
    }
}
