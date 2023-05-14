using GameProject.Abstract;
using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        private readonly ICheckRealPerson checkRealPerson;
        public GamerManager(ICheckRealPerson checkRealPerson)
        {

            this.checkRealPerson = checkRealPerson;

        }
        public void Add(Gamer gamer)
        {
            if (checkRealPerson.Check(gamer))
            {
                Console.WriteLine("Oyuncu Eklendi.");
            }
            else
            {
                Console.WriteLine("Oyuncu Eklenemedi.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi."+ gamer.Name);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi." + gamer.Name);
        }
    }
}
