namespace State.Ex1
{
    public class Ship
    {
        public IShipState CurrentState { get; private set; }

        public void ChangeState(IShipState newState)
        {
            CurrentState = newState;
            CurrentState.Execute(this);
        }
    }
}