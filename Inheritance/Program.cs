namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Honk();
            Console.WriteLine(car.brand+" "+car.modelName);
        }
    }
}