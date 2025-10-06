using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord.Classes
{
    public class Generic
    {
        public void ShowType<T>(T item) // Método genérico que aceita um parâmetro de qualquer tipo.
        {
            Console.WriteLine($"O tipo do item é: {item?.GetType()} e o valor é: {item}");
        }
    }
}
