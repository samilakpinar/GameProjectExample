using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entites
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Provider { get; set; }
        public DateTime RelaseDate { get; set; }
        public int Price { get; set; }
    }
}
