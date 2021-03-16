namespace AbstractFabric.Example2
{
    public interface IShipFactory
    {        
        IWeapon AddWeapon();
        IEngine AddEngine();
    }
}