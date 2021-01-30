using GamerApp.Entities;
using GamerApp.GamerApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerApp.Absstract
{
    public interface IGamerService
    {
        void Register(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
        void Purchase(Game game);
    }
}
