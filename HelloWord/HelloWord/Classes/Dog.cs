using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord.Classes
{
    public class Dog : Animal // Classe derivada de Animal. Os : indicam herança (Animal é a classe base).
    {
        public Dog(string name, int age)
            : base(name, age) // Chama o construtor da classe base (Animal) para inicializar os membros herdados.
        { }
    }
}
