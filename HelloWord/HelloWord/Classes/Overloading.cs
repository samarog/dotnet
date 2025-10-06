using System;
using System.Linq;

namespace HelloWord.Classes
{
    class Overload // Fazer com que uma classe possa aceitar mais do que um tipo de variável
    {
        public static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        public static double PlusMethod(double x, double y)
        {
            return x + y;
        }

    }
}
