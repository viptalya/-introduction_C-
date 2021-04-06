using System;
using System.Diagnostics;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и
            позволяет завершить указанный процесс. Предусмотреть возможность завершения процессов с
            помощью указания его ID или имени процесса. В качестве примера можно использовать консольные
            утилиты Windows tasklist и taskkill.
            */
            try
            {
                Process process = Process.Start("notepad.exe");
                Console.WriteLine(process.Id) ;
                Console.WriteLine("Введите ID процесса, который нужно завершить");
                int id = Convert.ToInt32(Console.ReadLine());
                if(id == process.Id)
                {
                    process.Kill();
                }
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так :)");
            }
        }
    }
}
