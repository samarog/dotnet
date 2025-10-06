using System;

namespace HelloWord.Classes
{
    public class CarPrivate
    {
        private string _brand; // private field

        public string Brand { 
        get => _brand;
        set {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Brand cannot be null or empty.");
                _brand = value;
            }
        }

        public string Model { get; set; } // auto-implemented property. this is the modern way to do it. this returns the private field _model but you don't need to write the code for it. if set is private, you can only set it inside the class.
        public string Color { get; set; } // not-nullable string - NÃO pode ser null
        public string? SecondaryColor { get; set; } // nullable string -  // pode ser null, mas tens de fornecer na mesma o argumento ao construtor
        public int Year { get; set; }

        public CarPrivate(string brand, string model, string color, int year, string? secondaryColor) // constructor
        {
            Brand = brand;
            Model = model;
            Color = color;
            Year = year;
            SecondaryColor = secondaryColor;
        }
    }
}
