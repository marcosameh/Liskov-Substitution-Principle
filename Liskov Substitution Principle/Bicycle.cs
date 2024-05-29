namespace Liskov_Substitution_Principle
{
    public class Bicycle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Bicycle start Moving");
        }
    }
}
