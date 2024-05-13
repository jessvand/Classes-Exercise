namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ShirleyTilda = new Car();

            ShirleyTilda.Make = "Chevrolet";
            ShirleyTilda.Model = "Cobalt";
            ShirleyTilda.Year = "2008";

            Console.WriteLine($"My car is a {ShirleyTilda.Year} {ShirleyTilda.Make} {ShirleyTilda.Model} and her name is Shirley Tilda");

        }
    }
}
