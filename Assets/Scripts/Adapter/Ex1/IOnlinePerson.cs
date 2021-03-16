namespace Adapter.Ex1
{
    public interface IOnlinePerson
    {
        string GetFirstName(int userId);
        string GetLastName(int userId);
        string GetClass(int userId);

        string GetFullName(int userId);

    }
}