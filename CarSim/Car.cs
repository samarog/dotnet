namespace CarSim
{
    public class Car
    {
        private static readonly Random Rng = new Random();

        private string _brand;
        private int _year;
        private int _mileage;
        private int _fuel;

        public const int MaxFuel = 500;
        private const int ConsumptionPerKm = 2;

        public string Model { get; set; }

        public string Brand
        {
            get => _brand;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Brand is required.", nameof(value));
                _brand = value.Trim();
            }
        }

        public int Year
        {
            get => _year;
            set
            {
                var now = DateTime.Now.Year;
                if (value < 1896 || value > now)
                    throw new ArgumentOutOfRangeException(nameof(value), "Invalid year.");
                _year = value;
            }
        }

        public int Mileage
        {
            get => _mileage;
            private set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));
                _mileage = value;
            }
        }

        public int Fuel
        {
            get => _fuel;
            private set
            {
                if (value < 0 || value > MaxFuel)
                    throw new ArgumentOutOfRangeException(nameof(value), $"Fuel must be between 0 and {MaxFuel}.");
                _fuel = value;
            }
        }

        public bool IsEngineOn { get; private set; }

        public Car(string brand, string model, int year, int mileage = 0, int? initialFuel = null)
        {
            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Model is required.", nameof(model));

            Brand = brand;
            Model = model.Trim();
            Year = year;
            Mileage = mileage;
            Fuel = initialFuel ?? Rng.Next(MaxFuel + 1);
        }

        public void StartEngine()
        {
            if (IsEngineOn) return;
            if (Fuel <= 0)
            {
                Console.WriteLine("Cannot start. No fuel.");
                return;
            }
            IsEngineOn = true;
            Console.WriteLine($"{Brand} {Model} engine started. Fuel: {Fuel}/{MaxFuel}.");
        }

        public void StopEngine()
        {
            if (!IsEngineOn) return;
            IsEngineOn = false;
            Console.WriteLine($"{Brand} {Model} engine stopped.");
        }

        public int Refuel(int amount)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be positive.");
            var before = Fuel;
            var space = MaxFuel - before;
            var added = Math.Min(space, amount);
            Fuel = before + added;
            Console.WriteLine($"Refueled {added}. Fuel: {Fuel}/{MaxFuel}.");
            return Fuel;
        }

        public void Drive(int km)
        {
            if (!IsEngineOn) throw new InvalidOperationException("Engine is off.");
            if (km <= 0) throw new ArgumentOutOfRangeException(nameof(km), "Distance must be positive.");

            var required = km * ConsumptionPerKm;

            if (required <= Fuel)
            {
                Fuel -= required;
                Mileage += km;
                Console.WriteLine($"Drove {km} km. Mileage: {Mileage} km. Fuel: {Fuel}/{MaxFuel}.");
                return;
            }

            // Not enough fuel: drive as far as possible, then stall.
            var kmPossible = Fuel / ConsumptionPerKm; // integer division
            if (kmPossible > 0)
            {
                Mileage += kmPossible;
                Console.WriteLine($"Drove {kmPossible} km and stalled out of fuel.");
            }
            Fuel = 0;
            IsEngineOn = false;
            Console.WriteLine($"Stopped. Mileage: {Mileage} km. Fuel: {Fuel}/{MaxFuel}.");
        }

        public override string ToString()
            => $"Brand: {Brand}, Model: {Model}, Year: {Year}, Mileage: {Mileage}, Fuel: {Fuel}/{MaxFuel}";
    }
}