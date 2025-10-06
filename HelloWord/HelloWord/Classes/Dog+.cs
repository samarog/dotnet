using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord.Classes
{
    public class DogPlus
    {
        public string Name { get; private set; }

        private int _age;

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(
                        nameof(value),
                        "Idade nunca pode ser negativa"
                    );
                _age = value;
            }
        }

        // Construtor
        public DogPlus(string name, int age)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Age = age; // ✅ goes through the property, so validation runs here
        }

        // Destrutor (finalizer) - bom para eliminar traces, fechar ligações a bases de dados, etc. // saber + sobre Garbage Collector

        ~DogPlus()
        {
            Console.WriteLine($"DogPlus object for {Name} is being finalized.");
        }
    }
}
