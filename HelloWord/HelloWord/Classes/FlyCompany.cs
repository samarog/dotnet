using HelloWord.Interfaces;

namespace HelloWord.Classes
{
    public class FlyCompany // sem constructor explícito, o C# cria um constructor default, que é a própria classe sem parâmetros

        : IFuel // entretanto, a classe FlyCompany implementa a interface IFuel, que obriga a implementar o método Fuel().

    // As interfaces são usadas para definir contratos que as classes podem implementar.

    {

        // tudo isto abaixo são os membros da classe FlyCompany: variáveis, constantes, propriedades e métodos

        public int id = 0272; // hardcoded field

        public const string Country = "USA"; // constant field

        string _planeModel; // backing field, por definição toda a variável é private
        public string PlaneModel // A property is like a combination of a variable and a method, and it has two methods: a get and a set method:
        {
            get { return _planeModel; } // isto é um property e faz o papel de um getter, ou seja, devolve o valor quando é chamado
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("O modelo do avião tem de ser colocado.");
                _planeModel = value;
            } // isto é um property e faz o papel de um setter, ou seja, atribui o valor quando é chamado
        }

        public string? Name { get; set; } // auto-implemented property // less code, more concise. the compiler creates a backing field for you.
        public void Fly() // method
        {
            Console.WriteLine("Flying...");
        }
        public void Land()
        // another method

        {
            Console.WriteLine("Landing...");
        }

        public void Fuel() // method from IPaint interface
        {
            Console.WriteLine("Fueling the plane...");
        }
    }
}
