using System;

namespace State
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player player = new Player();

            player.State = new PlayState(player);

            player.State.ClickLock();
            player.State.ClickPlay();
            player.State.ClickExit();
            Console.Read();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
