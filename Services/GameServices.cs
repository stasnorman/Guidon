using GuidonApp.Models;

namespace GuidonApp.Services
{
    public class GameService
    {
        public Game CreateNewGame()
        {
            // Логика создания новой игры
            return new Game { Id = 1, Name = "New Game" };
        }


    }
}