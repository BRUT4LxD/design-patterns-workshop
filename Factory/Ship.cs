using System;

namespace Factory
{
    internal class Ship : ITransport
    {
        public string Name { get; set; }
        public int ProductionYear { get; set; }

        public void Move()
        {
            Console.WriteLine("SIUMMM... BLUM");
        }

        public void IntroduceYourself()
        {
            Console.WriteLine("Hello I'm a ship full of sheeps");
        }
    }
}
