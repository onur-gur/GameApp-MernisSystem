using GamerApp.Adapters;
using GamerApp.Concrete;
using GamerApp.GamerApp;
using System;

namespace GamerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Register(new Gamer { Id = 1, NationalityId = "55544466677", FirstName = "name", LastName = "last_name", DateOfBirth = new DateTime(1881, 4, 30) });

        }
    }
}
