using System;

namespace Builder
{
    internal class Program
    {
        protected Program()
        {

        }

        private static void Main(string[] args)
        {
            var director = new Director();
            director.BuildHouse(new BigHouseBuilder());
            director.BuildHouse(new SmallHouseBuilder());
            Console.ReadKey();

        }
    }
}
