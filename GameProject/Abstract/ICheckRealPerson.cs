using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface ICheckRealPerson
    {
        bool Check(Gamer gamer);
    }
}
