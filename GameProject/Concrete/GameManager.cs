using GameProject.Abstract;
using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Sell(Gamer gamer, Game game)
        {
            Console.WriteLine("oyun satıldı: "+ gamer.Name + " " + game.Name);
        }
    }
}
