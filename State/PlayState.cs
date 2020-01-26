using System;

namespace State
{
    public class PlayState : AbstractState
    {
        public override void ClickLock()
        {
            Player.State = new LockState(Player);
            Console.WriteLine("Changing from Play to lock");
        }

        public override void ClickPlay()
        {
            //do nothing
        }

        public override void ClickExit()
        {
            Player.State = new ExitState(Player);
            Console.WriteLine("Changing from Play to Exit");
        }

        public PlayState(Player player) : base(player)
        {
        }
    }
}