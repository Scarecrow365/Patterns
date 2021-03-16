namespace Adapter.Ex1
{
    public class Adapter : OnlinePerson, IOnlinePerson
    {
        public string GetFullName(int id)
        {
            return GetFirstName(id) + " " + GetLastName(id);
        }
    }
}