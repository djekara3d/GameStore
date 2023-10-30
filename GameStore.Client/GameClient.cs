using GameStore.Client.Models;

namespace GameStore.Client
{
    public static class GameClient
    {

        private static readonly List<Game> gameList = new()
                {
                new Game ()
                {
                Id=1,
                Name="Street Fighter II",
                Genre="Fighting",
                Price =19.99M,
                ReleaseDate=new DateTime(1991,2,1)
                },
                new Game ()
                {
                Id=2,
                Name="Final Fantasy XIV",
                Genre="Roleplaying",
                Price =59.99M,
                ReleaseDate=new DateTime(2010,4,11)
                },
                new Game ()
                {
                Id=3,
                Name="FIFA 23",
                Genre="Sports",
                Price =19.99M,
                ReleaseDate=new DateTime(2022,9,19)
                }
                };


        public static Game[] GetGames()
        {
            return gameList.ToArray();
        }

        public static void AddGame(Game g)
        {
            g.Id = gameList.Count() + 1;
            gameList.Add(g);

        }


        public static Game GetGame(int id)
        {
            return gameList.Find(game => game.Id == id) ?? throw new Exception("Could not find game!");
        }


        public static void UpdateGame(Game updatedgame)
        {
            Game existingGame = GetGame(updatedgame.Id);
            existingGame.Name = updatedgame.Name;
            existingGame.Genre = updatedgame.Genre;
            existingGame.Price = updatedgame.Price;
            existingGame.ReleaseDate = updatedgame.ReleaseDate;

        }

        public static void DeleteGame(int id)
        {
            Game game = GetGame(id);
            gameList.Remove(game);
        }


    };




}