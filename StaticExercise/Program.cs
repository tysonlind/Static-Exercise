namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            double tempInC = TempConverter.FahrenheitToCelcius(25);
            Console.WriteLine(tempInC.ToString());
            double tempInF = TempConverter.CelciusToFahrenheit(-3.88889);
            Console.WriteLine(tempInF.ToString());
        }
    }
}
