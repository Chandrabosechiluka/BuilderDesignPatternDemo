using BuilderDesignPatternDemo.Models;

namespace BuilderDesignPatternDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBikeBuilder touringBikeBuilder = new TouringBikeBuilder();
            BikeDirector director = new BikeDirector(touringBikeBuilder);
            director.BuildBike();
            Bike touringBike = director.GetBike();
            Console.WriteLine(touringBike);

            IBikeBuilder sportsBikeBuilder = new SportsBikeBuilder();
            director = new BikeDirector(sportsBikeBuilder);
            director.BuildBike();
            Bike sportsBike = director.GetBike();
            Console.WriteLine(sportsBike);
        }
    }
}
