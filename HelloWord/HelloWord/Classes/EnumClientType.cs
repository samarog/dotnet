using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord.Classes
{
    public enum EnumClientType
    {
        Particular, // isto tem defaults, se não se disser nada. Ou seja, Particular = 0 // int é o tipo de dados por defeito
        Empresarial, // Empresarial = 1
        Governamental // Governamental = 2 ... quase como se fosse os indexes de uma array
    }
}
