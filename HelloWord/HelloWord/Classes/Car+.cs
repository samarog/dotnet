using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord.Classes
{
    public class CarPlus : Vehicle // com constructor, o constructor tem de ter o mesmo nome da classe. o que distingue o constructor da classe é os parênteses ().
                                   // por exemplo: public class CarPlus é classe (com constructor implícito) e public CarPlus() é constructor (explícito).
                                   // Um constuctor é um método especial que é chamado quando uma instância (objeto) da classe é criada.
                                   // Um constuctor não tem 'class' no nome. se o bloco tiver 'public class XXX' <--- isto é uma classe, não um constructor.
                                   // um constructor não tem tipo de retorno. um constructor por defeito é público e pode ser chamado em qualquer lugar.
                                   // Também pode ser overloaded, ou seja, podes ter vários constructors com diferentes parâmetros.
    {
        private string _brand; // private field
        public string Brand { get => _brand; set {
            if(string.IsNullOrWhiteSpace(value)) throw new ArgumentException("A marca tem de ser colocada.");
            _brand = value;
            } }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public bool IsReg { get; set; }

        public CarPlus(int id, string type, string brand, string model, string color, int year, bool isreg) : base(id, type)

        {

            Brand = string.IsNullOrWhiteSpace(brand) ? throw new ArgumentException("A marca tem de ser colocada.") : brand;
            Model = model;
            Color = color;
            Year = year;
            IsReg = isreg;

        }
    }
}
