//1.1. Вывести на одной строке числа 31, 18 и 79 с одним пробелом между ними. Текст '31 18 79' не использовать.
static void Main()
        {
            int a =  31,b = 18,c = 79;
            Console.WriteLine($"{a} {b} {c}");
            Console.ReadKey();
        }

// 1.2. Вывести на одной строке числа 47, 52 и 150 с двумя пробелами между ними. Текст '47 52 150' не использовать.
static void Main()
        {
            int a =  47,b = 52,c = 150;
            Console.WriteLine($"{a}  {b}  {c}");
            Console.ReadKey();
        }

// 1.3. Вывести на экран числа 50 и 10 одно под другим.
static void Main()
        {
            int a =  50,b = 10;
            Console.WriteLine($"{a}\n{b}");
            Console.ReadKey();
        }

// 1.4. Вывести на экран числа 5, 10 и 21 одно под другим.
static void Main()
        {
            int a = 5, b = 10, c = 21;
            Console.WriteLine($"{a}\n{b}\n{c}");
            Console.ReadKey();
        }

// 1.5. Получить на экране следующее:
// 1
// 
// 2
static void Main()
        {
            int a = 1, b = 2;
            Console.WriteLine($"{a}\n\n{b}");
            Console.ReadKey();
        }

// 1.6. Число π примерно равно 3,1415926. Вывести на экран это число с тремя цифрами в дробной части. Текст '3.142' не использовать.
static void Main()
        {
            double pi = 3.1415926;
            Console.WriteLine(Math.Round(pi,3));
            Console.ReadKey();
        }

// 1.7. Число e (основание натурального логарифма) приблизительно равно 2,71828. Вывести на экран это число с точностью до десятых. Текст '2.7' не использовать.
static void Main()
        {
            double e = 2.71828;
            Console.WriteLine(Math.Round(e, 1));
            Console.ReadKey();
        }

// 1.8. Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение «Вы ввели число».
static void Main()
        {
            Console.WriteLine("Enter any number: ");
            var num = Console.ReadLine();
            Console.WriteLine($"Your number is {num}.");
            Console.ReadKey();
        }

// 1.9. Составить программу вывода на экран числа, вводимого с клавиатуры. После выводимого числа должно следовать сообщение «– вот какое число Вы ввели».
static void Main()
        {
            Console.Write("Enter any number: ");
            var num = Console.ReadLine();
            Console.WriteLine($"{num} - is the number you enterd.");
            Console.ReadKey();
        }

// 1.10. Составить программу, которая запрашивает имя человека и повторяет его на экране. 
static void Main()
        {
            Console.Write("Enter any name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"{name} - is your name.");
            Console.ReadKey();
        }

// 1.11. Составить программу, которая запрашивает название футбольной команды и повторяет его на экране со словами «–это чемпион!».
static void Main()
        {
            Console.Write("Enter any name: ");
            var teamName = Console.ReadLine();
            Console.WriteLine($"{teamName} - is the Champion!");
            Console.ReadKey();
        }

// 1.12. Напишите программу, в которую вводится имя человека и выводится на экран приветствие в виде слова «Привет», после которого должна стоять запятая, введенное имя и восклицательный знак. После запятой должен стоять пробел, а перед восклицательным знаком пробела быть не должно.
static void Main()
        {
            Console.Write("Enter any name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hi, {name}!");
            Console.ReadKey();
        }

// 1.13. Напишите программу, в которую вводится целое число, после чего на экран выводится следующее и предыдущее целое число. Например, при вводе числа 15 на экран должно быть выведено:
// Следующее за числом 15 число – 16.
// Для числа 15 предыдущее число – 14.
static void Main()
        {
            Console.Write("Enter any number: ");
            var num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The number following the number {num} is {num + 1}.\r\nFor the number {num}, the previous number is {num - 1}.");
            Console.ReadKey();
        }

// 1.14. Составить программу вывода на экран в одну строку трех любых чисел, вводимых с клавиатуры, с двумя пробелами между ними.
static void Main()
        {
            int a =  1,b = 2,c = 3;
            Console.WriteLine($"{a}  {b}  {c}");
            Console.ReadKey();
        }


// 1.15. Составить программу вывода на экран в одну строку четырех любых чисел, вводимых с клавиатуры, с одним пробелом между ними.