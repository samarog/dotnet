using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord.Classes
{
    public class ExemploDeFunc // Classe que demonstra o uso de métodos com parâmetros de tipo base.
    {
        public static void Vet(Animal animal) // Método que aceita um parâmetro do tipo Animal
        {
            Console.WriteLine($"Cuidando do {animal.Name}"); // Exibe uma mensagem indicando que está a cuidar do animal
        }
    }
}
