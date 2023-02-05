namespace Memento.Ex1
{
    internal class Memento
    {
        public Memento(string name, string phone, double budget)
        {
            Name = name;
            Phone = phone;
            Budget = budget;
        }

        public string Name { get; }
        public string Phone { get; }
        public double Budget { get; }
    }
}