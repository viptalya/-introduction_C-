using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace lesson5
{
    public class ToDo
    {
        public string Title { get; set; }
        public string IsDone { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл. 
            */
            
            Console.WriteLine("Введи любой текст");
            string text = Console.ReadLine();
            string filename = "text.txt";
            File.WriteAllText(filename, text);

            /*
            2. Написать программу, которая при старте дописывает текущее время в файл
            «startup.txt». 
            */

            string date = Convert.ToString(DateTime.Now);
            string namefile = "startup.txt";
            File.AppendAllText(namefile, date);
            File.AppendAllText(namefile, Environment.NewLine);

            /*
            3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный
            файл.
            */

            Console.WriteLine("Введите набор (0...255) чисел");
            int number = Convert.ToInt32(Console.ReadLine());
            string nameF = "num.bin";
            byte[] num = { (byte)number };
            File.WriteAllBytes(nameF, num);

            /*
            4. (*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с
            рекурсией и без.
            */
            
            //без рекурсии, как с рекурсией сделать не придумал
            string workDir = @"C:\Users\пк\Desktop\geekbrains\introduction\lesson5";
            Console.WriteLine(Directory.Exists(workDir));
            string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.AllDirectories);
            for (int i = 0; i < entries.Length; i++)
            {
                File.AppendAllText("task4(norec).txt", entries[i]);
                File.AppendAllText("task4(norec).txt", Environment.NewLine);
            }

            /*
            5. (*) Список задач (ToDo-list):
                ● написать приложение для ввода списка задач;
                ● задачу описать классом ToDo с полями Title и IsDone;
                ● на старте, если есть файл tasks.json/xml/bin (выбрать формат), загрузить
                из него массив имеющихся задач и вывести их на экран;
                ● если задача выполнена, вывести перед её названием строку «[x]»;
                ● вывести порядковый номер для каждой задачи;
                ● при вводе пользователем порядкового номера задачи отметить задачу с этим
                порядковым номером как выполненную;
                ● записать актуальный массив задач в файл tasks.json/xml/bin.
            */

            //когда пытаюсь сделать десериализацию появляется ошибка, которую не понимаю как пофиксить
            //при этом дисериализация у файла без массива работает
            ToDo[] tdArr = new ToDo[]
            {
                new ToDo() {Title = "Прочесть задание", IsDone = "Выполнено"},
                new ToDo() {Title = "Написать код", IsDone = "В процессе"}
            };
            string todoName = "todolist.json";
            string json = JsonSerializer.Serialize<ToDo[]>(tdArr);
            File.WriteAllText(todoName, json);
            string read = File.ReadAllText(todoName);
            ToDo td = JsonSerializer.Deserialize<ToDo>(read);
            Console.WriteLine(td.Title);
        }
    }
}
