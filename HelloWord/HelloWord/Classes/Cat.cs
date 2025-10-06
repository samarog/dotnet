using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord.Classes
{
    public class Cat // With get/set as in java
    {
        private string _name; // sempre que o encapsulamento é privado usa-se nomes como _variavel ou _cenas (underscore e letra minuscula)
        private int _age; // definir uma variável dentro de um classe é definir um campo (field).

        // isto é um construtor. um construtor obriga a passar os argumentos e evita erros de input (a pessoa esquecer-se de valores quando inicializa a variável)
        public Cat(string name, int age)
        {
            if (age < 0)
                throw new Exception("Idade não pode ser negativa.");

            _name = name;
            _age = age;
        }

        // Getter
        public string GetName()
        {
            return _name;
        }

        public int GetAge()
        {
            return _age;
        }

        //Setter

        public void SetAge(int age)
        {
            if (age < 0)
                throw new Exception("Idade não pode ser negativa.");
            _age = age;
        }

        public void SetName(string name)
        {
            _name = name;
        }
    }

    // como construtor
}
