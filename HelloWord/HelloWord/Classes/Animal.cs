using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord.Classes
{
    public abstract class Animal // Classe base abstrata. Não pode ser instanciada diretamente.
    {
        public string Name { get; set; } // Propriedade automática com get e set públicos.
        public int Age { get; set; } // Propriedade automática com get e set públicos.
        public Animal(string name, int age) // Construtor que inicializa as propriedades.
        {
            Name = name; // Inicializa a propriedade Name.
            Age = age; // Inicializa a propriedade Age.
        }

        public void Walk() // Método comum a todas as classes derivadas.
        {
            Console.WriteLine($"{Name} está a andar"); // Exibe uma mensagem indicando que o animal está a andar.
        }

        public void Sleep() // Método comum a todas as classes derivadas.
        {
            Console.WriteLine($"{Name} está a dormir"); // Exibe uma mensagem indicando que o animal está a dormir.
        }

        public virtual void Morder() // Método virtual que pode ser sobrescrito por classes derivadas.
        {
            Console.WriteLine($"{Name} está a morder"); // Exibe uma mensagem indicando que o animal está a morder.
        }
    }
}
