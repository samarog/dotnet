namespace CarSim
{
    internal class Program
        {
            public static void Main()
            {
                var myCar = new Car("Toyota", "Corolla", 2015, mileage: 22000);

                myCar.StartEngine();
                myCar.Drive(25);
                myCar.StopEngine();

                myCar.StartEngine();
                myCar.Drive(56);
                myCar.StopEngine();

                myCar.StartEngine();
                myCar.Drive(133);
                myCar.StopEngine();

                myCar.Refuel(150);

                myCar.StartEngine();
                myCar.Drive(45);
                myCar.StopEngine();
            }
        }
    }