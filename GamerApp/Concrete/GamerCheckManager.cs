using GamerApp.Absstract;
using GamerApp.GamerApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerApp.Concrete
{
    public class GamerCheckManager : IGamerCheckServis
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
