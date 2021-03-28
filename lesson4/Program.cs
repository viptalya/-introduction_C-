using System;

namespace lesson4
{
    class Program
    {
        [Flags]
        enum season
        {
            winter,
            spring,
            summer,
            autumn
        }
        static void Main(string[] args)
        {
            /*
            1. Написать метод GetFullName(string firstName, string lastName, string
            patronymic), принимающий на вход ФИО в разных аргументах и возвращающий
            объединённую строку с ФИО. Используя метод, написать программу, выводящую в консоль
            3–4 разных ФИО.
            */

            for(int i = 0; i < 3; i++)
            {
                string FirstName = GetFirstName();
                string LastName = GetLastName();
                string Patronymic = GetPat();
                string answer = GetFullName(FirstName, LastName, Patronymic);
                Console.WriteLine(answer);
            }
            

            /*
            2. Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и
            возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести
            результат на экран.
            */

            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();
            string[] number = text.Split();
            int a = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int sum = int.Parse(number[i]);
                a = a + sum;
            }
            Console.WriteLine(a);
            

            /*
            3. Написать метод по определению времени года. На вход подаётся число – порядковый номер
            месяца. На выходе — значение из перечисления (enum) — Winter, Spring, Summer,
            Autumn. Написать метод, принимающий на вход значение из этого перечисления и
            возвращающий название времени года (зима, весна, лето, осень). Используя эти методы,
            ввести с клавиатуры номер месяца и вывести название времени года. Если введено
            некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
            */

            GetS();

            /*
            4. (*) Написать программу, вычисляющую число Фибоначчи для заданного значения
            рекурсивным способом.
            */

            Console.WriteLine("Введите число");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fib(f));
            

            /*
            5. (*)  Написать программу, вычисляющую факториал числа для заданного значения
            рекурсивным способом.
            */

            Console.WriteLine("Введите число для факториала");
            int F = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fact(F));

            /*
            6. (**) Вычислить факториал без рекурсии
            */
            Factorial();
        }
        //1
        public static string GetFirstName()
        {
            Console.WriteLine("Введите имя");
            string firstName = Console.ReadLine();
            return firstName;
        }
        public static string GetLastName()
        {
            Console.WriteLine("Введите фамилию");
            string lastName = Console.ReadLine();
            return lastName;
        }
        public static string GetPat()
        {
            Console.WriteLine("Введите отчество");
            string patronymic = Console.ReadLine();
            return patronymic;
        }
        public static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"Привет {firstName} {lastName} {patronymic}";
        }
        //3
        public static string GetSeason()
        {
            string t = "";
            Console.WriteLine("Введите число");
            int s = Convert.ToInt32(Console.ReadLine());
            if(s == 12 || s == 1 || s == 2)
            {
                t = Convert.ToString((season)0);
            }
            else if(s == 3 || s == 4 || s == 5)
            {
                t = Convert.ToString((season)1);
            }
            else if(s == 6 || s == 7 || s == 8)
            {
                t = Convert.ToString((season)2);
            }
            else if(s == 9 || s == 10 || s == 11)
            {
                t = Convert.ToString((season)3);
            }
            else
            {
                Console.WriteLine("Введите корректный номер месяца");
            }
            return t;
        }
        public static string GetS()
        {
            string t = GetSeason();
            if(t == "winter")
            {
                Console.WriteLine("Зима");
            }
            else if(t == "spring")
            {
                Console.WriteLine("Весна");
            }
            else if (t == "summer")
            {
                Console.WriteLine("Лето");
            }
            else if (t == "autumn")
            {
                Console.WriteLine("Осень");
            }
            return t;
        }
        //4
        public static int Fib(int f)
        {
            if(f == 0)
            {
                return 0;
            }
            else if (f == 1)
            {
                return 1;
            }
            else
            {
                return Fib(f - 1) + Fib(f - 2);
            }
        }
        //5
        public static int Fact(int F)
        {
            if(F == 1)
            {
                return F;
            }
            else
            {
                return F * Fact(F - 1);
            }
        }
        //6
        public static int Factorial()
        {
            Console.WriteLine("Введите число");
            int fac = Convert.ToInt32(Console.ReadLine());
            int r = 1;
            for(int i = 1; i <= fac; i++)
            {
                r = r * i;
            }
            Console.WriteLine(r);
            return r;
        }
    }
}
