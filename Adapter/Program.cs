using System;

namespace Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RoundHole round = new RoundHole(22);
            RoundThing roundThing = new RoundThing { Radius = 10 };

            SquareThing squareThing = new SquareThing { Width = 21 };

            Console.WriteLine(round.Fits(roundThing));
            Console.WriteLine(round.Fits(new SquareThingAdapter(squareThing)));
            Console.ReadKey();

        }
    }
}
