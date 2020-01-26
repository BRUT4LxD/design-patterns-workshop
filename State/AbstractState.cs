namespace State
{
    public abstract class AbstractState
    {
        protected Player Player;

        protected AbstractState(Player player)
        {
            Player = player;
        }

        public virtual void ClickLock()
        {

        }

        public virtual void ClickPlay()
        {

        }

        public virtual void ClickExit()
        {

        }
    }
}
