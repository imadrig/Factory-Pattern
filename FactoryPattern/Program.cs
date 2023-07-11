namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does your vehicle have?");
            string userInput = Console.ReadLine();

            IVehicle userVehicle = VehicleFactory.GetVehicle(userInput);
            userVehicle.Drive();



        }
    }
}
