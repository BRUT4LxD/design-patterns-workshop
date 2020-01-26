using System;

namespace State
{
    public class LockState : AbstractState
    {
        public override void ClickLock()
        {
            throw new System.NotImplementedException();
        }

        public override void ClickPlay()
        {
            Player.State = new PlayState(Player);
            Console.WriteLine("Entering play from lock");
        }

        public override void ClickExit()
        {
            throw new System.NotImplementedException();
        }

        public LockState(Player player) : base(player)
        {
        }
    }
}