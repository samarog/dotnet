using HelloWord.App;
using HelloWord.Classes;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Reflection;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word!");
            Console.WriteLine("teste2");
            Console.WriteLine("teste3");
            Console.WriteLine(true);
            Console.WriteLine(5 + 7);

            int age = 38;
            string name = "Gonçalo";
            const char bloodType = 'A'; // read-only, requires value
            string bloodTypeAsAString = "A";
            float price = 12.3387F;
            long distMarsToEarth = 15000000000L;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(price);
            Console.WriteLine(bloodType);
            Console.WriteLine(distMarsToEarth);
            Console.WriteLine(bloodTypeAsAString);

            int x = 5,
                y = 6,
                z = 50; // multivar (separate with comma; datatype only on first)
            Console.WriteLine(z - x + y);

            /*
             Schema:

             int myAge = 38

            int = dataype
            myAge = identifier
            38 = value
             */

            // type casting

            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myDouble); // implicit type casting

            double yourDouble = 9.99;
            int yourInt = (int)yourDouble; // conversão explícita: requer o datatype entre ()
            Console.WriteLine(yourInt);

            int number = 101;
            double doubleNumber = 5.25;
            bool myBool = false;

            Console.WriteLine(Convert.ToString(number)); // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt)); // convert int to double
            Console.WriteLine(Convert.ToInt32(doubleNumber)); // convert double to int
            Console.WriteLine(Convert.ToInt32(myBool)); // convert bool to int (true: 1, false: 0)
            Console.WriteLine("Number " + number + " to bool: " + Convert.ToBoolean(number));
            Console.WriteLine("Number 0 to bool: " + Convert.ToBoolean(0));
            Console.WriteLine(Convert.ToString(myBool)); // convert bool to string

            // User Input

            Console.WriteLine("Enter your username:");
            string userName = Console.ReadLine(); // always return a string

            Console.WriteLine("Enter your age:");
            int userAge = Convert.ToInt32(Console.ReadLine()); // if number you need to covert to int/double/float/etc..

            // interpolation

            string fullName = $"My name is {userName} and I have {userAge} years old."; // REMEMBER
            Console.WriteLine(fullName);

            // access strings

            string patient = "John Doe";

            int charPos = patient.IndexOf("D");

            string patientSurname = patient.Substring(charPos);

            Console.WriteLine(patientSurname);

            // quotization

            string txt = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt);

            // ternary in C#

            int time = 20;
            string result = time < 18 ? "Good day" : "Good evening";
            Console.WriteLine(result);

            // switch

            string jenken = "blue";

            switch (jenken)
            {
                case "scissors":
                    Console.WriteLine("Scissors");
                    break;
                case "rock":
                    Console.WriteLine("Rock");
                    break;
                case "paper":
                    Console.WriteLine("Paper");
                    break;
                default:
                    Console.WriteLine("what?");
                    break;
            }

            // foreach (forsworn) = to for/in in javaScript

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" }; // this is how you define an array (as an object)
            int[] packs = { 12, 22, 14, 16, 5 };

            foreach (int pack in packs)
            {
                Console.WriteLine(pack);
            }

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            // Break and Continue in a forloop

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == "Ford")
                {
                    continue; // or break. o continue faz skip ao elemento da array que cumpre a condição; o break dá exit ao loop a partir daquela condição
                }
                Console.WriteLine(cars[i]);
            }

            cars[0] = "Opel";

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            string[] newCars = new string[4] { "Tesla ", "Audi ", "Fiat ", "Peugeot" }; // another way of creating an array of four elements and adding values right away

            foreach (string car in newCars)
            {
                Console.Write(car);
            }

            // However, you should note that if you declare an array and initialize it later, you have to use the new keyword:

            // Declare an array
            string[] evenMoreNewCars;

            // Add values, using new
            evenMoreNewCars = new string[] { "BYD", "Neox", "Lucid" };

            string[] fruits = { "kiwi", "apple", "mango", "banana" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Array.Sort(fruits);

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // System.Linq methods

            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max()); // returns the largest value
            Console.WriteLine(myNumbers.Min()); // returns the smallest value
            Console.WriteLine(myNumbers.Sum()); // returns the sum of elements

            // multidimensional arrays

            int[,] array2D =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
            };

            // comma is need to define array conditions. A three-dimensional array would have two commas: int[,,], and so on..

            Console.WriteLine(array2D[0, 2]); // Outputs 3 | This statement accesses the value of the element in the first row (0) and third column (2) of the numbers array.
            // 0 é row, 2 é column

            foreach (int i in array2D)
            {
                Console.WriteLine(i);
            }

            // Default param in a func

            static void MyMethod(string country = "Norway")
            {
                Console.WriteLine(country);
            }

            MyMethod("Sweden");
            MyMethod("India");
            MyMethod();
            MyMethod("USA");

            // Sweden
            // India
            // Norway
            // USA

            // A returning func

            static int MyNewMethod(int x, int y)
            {
                return x + y;
            }

            int finalNumber = MyNewMethod(10, 5);

            Console.WriteLine(finalNumber);

            static void ChildrenNames(string child1, string child2)
            {
                Console.WriteLine(
                    $"The best student was {child1}. On the other hand, {child2} was a deception."
                );
            }

            ChildrenNames("Jonas", "Rikard");

            int myNum1 = Overload.PlusMethod(8, 5);
            double myNum2 = Overload.PlusMethod(4.3D, 6.26D);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);

            // float vs double

            float f = 0.1f;
            double d = 0.1d;

            decimal m = 0.1m; // usar o decimal porque dá sempre o que pretendemos

            Console.WriteLine(f == d); // False, porque o double é mais preciso do que o float. usar sempre decimal

            Console.WriteLine(f.ToString(format: "N12"));
            Console.WriteLine(d.ToString(format: "N12"));
            Console.WriteLine(m.ToString(format: "N12"));

            // para comparar verdadeiramente floats c/ doubles

            Console.WriteLine("Comparação entre float e double: " + (Math.Abs(f - d) < 0.001));

            var client1 = EnumClientType.Empresarial;
            client1 = (EnumClientType)2; // isto é uma outra forma de procurar uma opção da lista mas sem escrever o nome. É ir por indexação.

            Console.WriteLine("O cliente é " + client1.ToString());

            var gato = new Cat("Ozzy", 4);

            var gato2 = new Cat(name: "Gimbras", age: 8);

            gato.SetAge(10);

            Console.WriteLine(
                $"My {gato.GetName()} never met {gato2.GetName()}. And the first has {gato.GetAge()} years old"
            );

            var cao = new Dog(name: "Pipa", age: 12);

            Console.WriteLine("A minha cadela é a " + cao.Name + " e tem " + cao.Age);

            DogPlus supercao = new DogPlus(name: "Rafik", age: 6);

            CatPlus gato3 = new CatPlus(name: "Pipito", age: 3, color: "laranja");

            Console.WriteLine($"O {supercao.Name} tem {supercao.Age} anos");
            Console.WriteLine($"O {gato3.Name} tem {gato3.Age} anos e é {gato3.Cor}");

            gato3.Miar();

            cao.Walk();
            gato3.Walk(); // ambos os animais herdaram o método Walk da classe base Animal

            cao.Sleep();
            gato3.Sleep(); // ambos os animais herdaram o método Sleep da classe base Animal

            gato3.Morder(); // o gato3 (CatPlus) sobrescreveu o método Morder da classe base Animal
            cao.Morder(); // o cao (DogPlus) usa o método Morder original da classe base Animal

            Animal gatoNaFormaAnimal = new CatPlus("Noelia", 5, "malhada");

            gatoNaFormaAnimal.Morder(); // o gatoNaFormaAnimal (CatPlus) sobrescreveu o método Morder da classe base Animal

            ExemploDeFunc.Vet(gato3); // passando um CatPlus para um método que espera um Animal (herança)

            var listaDeAnimais = new List<CatPlus>(
                new CatPlus[] {
                    new CatPlus("Cat1", 1, "black"),
                    new CatPlus("Cat2", 2, "white"),
                    new CatPlus("Cat3", 3, "orange"),
                }
                );

            Console.WriteLine("Lista de animais tem " + listaDeAnimais.Count + " elementos");

            var myCar = new Car();
            myCar.Show();

            // Bank Sim

            //var account = new BankAccount("Alice", 1000m);

            //account.Deposit(200m);   // ✅ Balance = 1200
            //account.Withdraw(500m);  // ✅ Balance = 700
            //account.Withdraw(100m);
            //account.Deposit(300m);

            //Console.WriteLine(account.Balance.ToString());

            CarPrivate cliente1 = new CarPrivate(brand: "Opel", model: "Corsa", color: "azul", year: 2017, secondaryColor: null);

            Console.WriteLine($"O cliente comprou um {cliente1.Model} de cor {cliente1.Color} e com {DateAndTime.Now.Year - cliente1.Year} anos");

            CarPlus cliente2 = new CarPlus(1, "carro", "Tesla", "CyberTruck", "cinza", 2024, true);
            Console.WriteLine($"O cliente 2 comprou um {cliente2.vehicleType} da marca {cliente2.Brand} e modelo {cliente2.Model} e de cor {cliente2.Color} e com {DateAndTime.Now.Year - cliente2.Year} anos.");

            // Fly Company - simple get/set system

            // 1º passo: criar a classe FlyCompany em Classes/FlyCompany.cs

            // 2º passo: instanciar a classe e usar os seus membros
            var myCompany = new FlyCompany(); // instanciar a classe: isto significa que estás a criar um objeto da classe FlyCompany. isto é necessário para poderes aceder aos membros (propriedades e métodos) da classe.

            // 3º passo: usar os membros da classe. como? através do operador ponto (.). Exemplo:
            myCompany.Name = "TAP"; // set the Name property

            // 4º passo: ler os membros da classe

            Console.WriteLine(myCompany.Name);

            // instanciar outra empresa

            FlyCompany anotherCompany = new FlyCompany();

            anotherCompany.Name = "Ryanair";

            Console.WriteLine(anotherCompany.Name);

            anotherCompany.Fly();

            // ainda mais outra empresa

            FlyCompany thirdCompany = new FlyCompany();

            thirdCompany.Name = "Lufthansa";

            Console.WriteLine(thirdCompany.Name);

            var t = typeof(FlyCompany);

            var fields = t.GetFields(); // gets fields only

            foreach (var e in t.GetProperties())
            {
                Console.WriteLine(e.Name);
            }

            foreach (var e in t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                Console.WriteLine(e.Name);
            }

            Console.WriteLine("O cliente é " + client1);

            int month = (int)EnumMonths.April; // casting enum to int with (int) . General form of a cast: (TargetType) expression
            Console.WriteLine(month);

            Streamer myFile = new Streamer();

            myFile.WriteFile();

            // escaping

            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello \"World\"!");
            Console.WriteLine("c:\\source\\repos"); // escaping backslash in URLs. Use double backslash (\\) to represent a single backslash (\).

            // invoice mockup

            Console.WriteLine("Generating invoices for costumer \"Contoso Corp\" ... \n");
            Console.WriteLine("Invoice: 1021\t\t... Complete!");
            Console.WriteLine("Invoice: 1022\t\t... Complete!");
            Console.WriteLine("\nOutput Directory:\t");

            // verbatim string literal (ignores escape characters, keeps formatting as is)

            Console.WriteLine(@"c:\invoices\2025\
__________________________________________________
");

            // combining verbatim string literal with interpolation

            string costumer = "Contoso Corp";
            int yearInvoice = 2025;
            Console.WriteLine($@"c:\invoices\{yearInvoice}\{costumer}\");

            // OR

            string projectName = "ACME";
            string russianMessage = "Posmotret' vyvod Russina";

            Console.WriteLine($@"View English output:
  c:\Exercice\{projectName}\data.txt");
            Console.Write("\n");
            Console.WriteLine($@"{russianMessage}:
  c:\Exercice\{projectName}\ru-RU\data.txt");

            Console.WriteLine("C:\new\folder");

            // What happens if you try to use the + symbol with both string and int values? The int value is converted to a string before the concatenation.

            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets."); // This produces the following output: "Bob sold 77 widgets."

            // Para poder fazer override do string concatenation, é necessário usar parênteses para forçar a avaliação da expressão matemática primeiro.

            Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets."); // Outputs "Bob sold 14 widgets."

            // GPA Calc
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            int gradeA = 4;
            int gradeB = 3;

            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            int totalCreditHours = 0;
            totalCreditHours += course1Credit;
            totalCreditHours += course2Credit;
            totalCreditHours += course3Credit;
            totalCreditHours += course4Credit;
            totalCreditHours += course5Credit;

            int totalGradePoints = 0;
            totalGradePoints += course1Credit * course1Grade;
            totalGradePoints += course2Credit * course2Grade;
            totalGradePoints += course3Credit * course3Grade;
            totalGradePoints += course4Credit * course4Grade;
            totalGradePoints += course5Credit * course5Grade;

            decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

            int leadingDigit = (int)gradePointAverage;
            int firstDigit = (int)(gradePointAverage * 10) % 10;
            int secondDigit = (int)(gradePointAverage * 100) % 10;

            Console.WriteLine($"Student: {studentName}\n");
            Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

            Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
            Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
            Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
            Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
            Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

            Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");

            Console.Clear();

            // random (using the class Random)

            Random dice = new Random(); // métodos que tenham de ser obrigatoriamente instanciados é porque são stateful. Os outros que não têm de ser instanciados (como o Console.WriteLine) são stateless.
            int roll = dice.Next(1, 7);
            Console.WriteLine("The dice landed on " + roll);

            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101); // um bom exemplo de overloads diferentes

            // coin flip

            Random coin = new Random();
            int toss = coin.Next(0, 2); // 0 or 1 / heads or tails
            int toss2 = coin.Next(0, 2); // 0 or 1 / heads or tails
            int toss3 = coin.Next(0, 2); // 0 or 1 / heads or tails
            int toss4 = coin.Next(0, 2); // 0 or 1 / heads or tails
            int toss5 = coin.Next(0, 2); // 0 or 1 / heads or tails
            Console.WriteLine(toss == 0 ? "Heads" : "Tails");
            Console.WriteLine(toss2 == 0 ? "Heads" : "Tails");
            Console.WriteLine(toss3 == 0 ? "Heads" : "Tails");
            Console.WriteLine(toss4 == 0 ? "Heads" : "Tails");
            Console.WriteLine(toss5 == 0 ? "Heads" : "Tails");

            // fizzbuzz in List

            Console.Clear();

            List<string> fizzbuzz = new List<string>(); // List is a generic collection, part of System.Collections.Generic namespace

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    fizzbuzz.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    fizzbuzz.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    fizzbuzz.Add("Buzz");
                }
                else
                {
                    fizzbuzz.Add(i.ToString());
                }
            }

            // Print results
            foreach (var item in fizzbuzz)
            {
                Console.WriteLine(item);
            }

            // type conversion

            decimal a = 3.14m;
            Console.WriteLine($"decimal: {a}");

            int b = (int)a; // adicionamos (tipo-de-varíavel-pretendido) antes da variável para fazer a conversão explícita. Neste caso converte para int um variável decimal.
            Console.WriteLine($"int: {b}");

            int first = 5;
            int second = 7;
            string message = first.ToString() + second.ToString();
            Console.WriteLine(message);

            string cinco = "5";
            string sete = "7";
            int sum = int.Parse(cinco) + int.Parse(sete);
            Console.WriteLine(sum);

            // Casting != Converting

            double w = 9.8;

            // Usando casting (explicit cast):
            int i1 = (int)w;         // i1 = 9

            // Usando converting:
            int i2 = Convert.ToInt32(w); // i2 = 10 (faz arredondamento!)

            // Casting (int)d: trunca (corta) a parte decimal → 9.8 vira 9.

            // Converting Convert.ToInt32(d): aplica arredondamento padrão (Midpoint Rounding) → 9.8 vira 10

            Console.WriteLine($"Casting: {i1}, Converting: {i2}"); // Outputs: Casting: 9, Converting: 10

            // int.Parse(variável) vs int.TryParse(variável-de-entrada, out variável-de-saída)

            string input = "123";
            int numberParsed;

            if (int.TryParse(input, out numberParsed))
            {
                Console.WriteLine($"Parsing successful: {numberParsed}");
            }
            else
            {
                Console.WriteLine("Parsing failed.");
            }

            // Sorting is ok with Array.Sort() or LINQ

            // reverse and join

            string value = "abc123";
            char[] valueArray = value.ToCharArray();

            foreach (char c in valueArray)
            {
                Console.WriteLine(c);
            }

            Array.Reverse(valueArray);
            string resultado = new string(valueArray);
            resultado = string.Join(", ", valueArray);
            Console.WriteLine(result);

            CultureInfo myCulture = new CultureInfo("pt-PT");

            decimal preço = 123.45m;
            int desconto = 50;
            Console.WriteLine($"Price: {preço:C} (Save {desconto:C})"); // com C faz formatação monetária ajustada a Cultura

            // exemplo de lógica de faturação simples

            decimal priceA = 220.45m - 20.45m;
            int discount = 5;
            decimal tax = 0.10m;

            decimal taxValue = (((priceA * tax) * 100) / 100);
            decimal finalPrice = priceA + taxValue - discount;

            Console.WriteLine($"Price: {priceA:C} (Save {discount:C}) (Tax {tax:P2})");
            Console.WriteLine($"Final price: {finalPrice:C}");

            // bom exemplo de passar por referência com ref

            /*  
            This code instantiates a value and then calls the ChangeValue method
            to update the value. The code then prints the updated value to the console.
            */

            int zyx = 5;

            ChangeValue(ref zyx);

            Console.WriteLine(zyx);

            void ChangeValue(ref int zyx) // passar por referência muda o valor da variável - sem isto a variável x voltava a ser 5 após sair do método ChangeValue
            {
                zyx = 10;
            }

            // Good example of a try/catch block

            // inputValues is used to store numeric values entered by a user
            string[] inputValues = new string[] { "three", "9999999999", "0", "2" };

            foreach (string inputValue in inputValues)
            {
                int numValue = 0;
                try
                {
                    numValue = int.Parse(inputValue);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid readResult. Please enter a valid number. " + ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("The number you entered is too large or too small. " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Conversion

            // int > string

            int ageJack = 20;

            string mane = ageJack.ToString(); // ToString is a compile-time method to convert any datatype to string.
                                              // Every datatype in C# inherits from the Object class, which includes the ToString method.
                                              // So any datatype can use this method.

            // Convert.ChangeType is an useful alternative in dynamic scenarios, when the type is not known at compile time.
            // For example, when reading from a database or a file. Or when waiting for user input.

            Console.WriteLine("" + mane);
            Console.WriteLine(ageJack.GetType().Name); // the original variable type never changes. Convertion creates a new variable of the new type.

            // string > int
            string numberAsString = "12345";
            int numberAsInt = int.Parse(numberAsString); // int.Parse is a compile-time method to convert a string to an int.
                                                         // It throws an exception if the string is not a valid int.

            // Use int.TryParse to avoid exceptions. It returns a boolean indicating success or failure.
            // If successful, it outputs the converted value via an out parameter.

            // value.ToString(0.###) - formats a number to a string with up to three decimal places, removing unnecessary trailing zeros.

            // string.ToUpper() - converts all characters in a string to uppercase.

            int date1 = 20240426;
            string newDate = date1.ToString("YYYY-MM-DD"); // formats the integer as a date string in the format "YYYY-MM-DD".
            Console.WriteLine(newDate);


            Console.WriteLine("Press any key to end the test run...");
            Console.ReadKey();
            Console.WriteLine("The test run has ended. Thank you");
        }
    }
}

