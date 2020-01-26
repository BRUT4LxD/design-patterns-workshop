namespace State
{
    public class ExitState : AbstractState
    {
        public override void ClickLock()
        {
            throw new System.NotImplementedException();
        }

        public override void ClickPlay()
        {
            throw new System.NotImplementedException();
        }

        public override void ClickExit()
        {
            throw new System.NotImplementedException();
        }

        public ExitState(Player player) : base(player)
        {
        }
    }
}