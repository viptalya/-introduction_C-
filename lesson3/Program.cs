using System;
using System.Collections.Generic;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Написать программу, выводящую элементы двумерного массива по диагонали. (не сделал)
            */
            int[,] a2 = { { 3, 2, 1 }, { 5, 6, 8 } };
            int rows = a2.GetLength(0);
            int colums = a2.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; i < colums; j++)
                {
                    Console.Write($"{a2[i, j]}\t");
                }
                Console.WriteLine();
            }
            /*
            2. Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий
            список телефонных контактов: первый элемент хранит имя контакта, второй — номер
            телефона/e-mail.
            */
            string[,] arr = {
            {"Иванов", "89563256685"},
            {"Петров", "P@gmail.com"},
            {"Сидоров", "sidor@yandex.ru"},
            {"Колодочкин", "89336587796"},
            {"Табаков", "89132587469"},
            };

            int raw = arr.GetLength(0);
            int colums = arr.GetLength(1);

            for (int i = 0; i < raw; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{arr[i, j]}\n");
                }
                Console.WriteLine();
            }
            /*
            3. Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH
            вместо Hello).
            }*/
            Console.WriteLine("Введите строку");

            string text = Console.ReadLine();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
            /*
            4. * «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, где Х —
            элементы кораблей, а О — свободные клетки.
            }*/
            char[,] war = {
            {'X','O','O','O','X','O','O','O','O','O'},
            {'X','O','X','O','O','O','X','X','X','O' },
            {'X','O','X','O','O','O','O','O','O','O' },
            {'X','O','O','O','X','O','O','O','O','X' },
            {'O','O','O','O','O','O','O','O','O','O' },
            {'O','O','O','O','O','O','O','X','X','O' },
            {'O','O','O','O','O','O','O','O','O','O' },
            {'O','O','X','O','O','O','O','O','O','O' },
            {'X','O','X','O','O','O','X','X','O','O' },
            {'O','O','X','O','O','O','O','O','O','O' },
            };

            int raw = war.GetLength(0);
            int colums = war.GetLength(1);

            for (int i = 0; i < raw; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{war[i, j]}");
                }
                Console.WriteLine();
            }

            /*
            5. **Отсортировать массив
            */
            int[] arr = new int[5];
            Console.WriteLine("Введите 5 чисел");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("От большего к меньшему: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("От меньшего к большему: ");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}