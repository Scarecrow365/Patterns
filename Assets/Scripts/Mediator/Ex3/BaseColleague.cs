namespace Mediator.Ex3
{
    internal abstract class BaseColleague
    {
        protected readonly BaseMediator BaseMediator;

        protected BaseColleague(BaseMediator baseMediator)
        {
            BaseMediator = baseMediator;
        }
    }
}