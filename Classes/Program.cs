namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car(); 
            carOne.Make = "Toyota";
            carOne.Model = "Corolla";
            carOne.Year = 2020;
            
            Console.WriteLine($"This is a {carOne.Year} {carOne.Make} {carOne.Model}");
        }
    }
}