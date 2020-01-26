using System;

namespace Factory
{
    internal class Program
    {
        protected Program()
        {

        }
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var myCar = TransportFactory.CreateTransport(true);
            myCar.IntroduceYourself();
            var myShip = TransportFactory.CreateTransport(false);
            myShip.IntroduceYourself();

            Console.ReadKey();

        }
    }
}
