namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ShirleyTilda = new Car();

            ShirleyTilda.Make = "Chevrolet";
            ShirleyTilda.Model = "Cobalt";
            ShirleyTilda.Year = (2009);

            Console.WriteLine($"My car's a {ShirleyTilda.Year} {ShirleyTilda.Make} {ShirleyTilda.Model}");

        }
    }
}
