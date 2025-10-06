namespace HelloWord.Classes
{
    public abstract class Vehicle
    {
        public int vehicleId { get; set; }

        public string vehicleType { get; set; }

        public Vehicle(int id, string type)
        {
            vehicleId = id;
            vehicleType = type;
        }

    }
}
