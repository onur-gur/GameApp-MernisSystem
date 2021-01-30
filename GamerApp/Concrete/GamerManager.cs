using GamerApp.Absstract;
using GamerApp.Entities;
using GamerApp.GamerApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerApp.Concrete
{
    public class GamerManager : IGamerService
    {
        private IGamerCheckServis _gamerCheckService;

        public GamerManager(IGamerCheckServis gamerCheckServis)
        {
            _gamerCheckService = gamerCheckServis;
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Eklendi");
        }
        public void Register(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Kayıt oldunuz "+gamer.FirstName);
            }
            else
            {
                throw new Exception("Not a valid Gamer");
            }


        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Güncellediniz");
        }
        public void Purchase(Game game)
        {
            Console.WriteLine("Satın aldınız");
        }





    }
}
