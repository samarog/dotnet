using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord.Classes
{
    public class CatPlus : Animal // Classe derivada de Animal. Os : indicam herança (Animal é a classe base).
    {
        
        public string Cor { get; set; } // Propriedade adicional específica da classe CatPlus.

        public void Miar()
        {
            Console.WriteLine("Miau!");
        }
        public override void Morder() // Sobrescreve o método Morder da classe base (Animal).
        {
            Console.WriteLine($"{Name} está a morder como morde um gato!"); // Exibe uma mensagem específica para gatos.
        }

        public CatPlus(string name, int age, string color)
            : base(name, age) // Chama o construtor da classe base (Animal) para inicializar os membros herdados. Ou seja, Name e Age são inicializados na classe base, enquanto Cor é inicializado aqui. Daí o base ser name e age.
        {

            Cor = color;
        
        }
    }
}
