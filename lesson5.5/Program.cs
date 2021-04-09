using System;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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
    public class ToDo
    {
        public string Title { get; set; }
        public string IsDone { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ToDo[] tdArr = new ToDo[]
            {
                new ToDo() {Title = "Прочесть задание", IsDone = "Выполнено"},
                new ToDo() {Title = "Написать код", IsDone = "В процессе"},
                new ToDo() {Title = "Завершить задание", IsDone = "В процессе"}
            };
            string todoName = "todolist.json";
            string json = JsonSerializer.Serialize<ToDo[]>(tdArr);
            File.WriteAllText(todoName, json);
            string read = File.ReadAllText(todoName);
            ToDo[] td = JsonSerializer.Deserialize<ToDo[]>(read);
            for(int i = 0; i < td.Length; i++)
            {
                Console.WriteLine($"Задание: {td[i].Title}, статус: {td[i].IsDone}");
            }
            for(int i = 0; i < td.Length; i++)
            {
                if(td[i].IsDone == "Выполнено")
                {
                    Console.WriteLine($"[X] {td[i].Title}");
                }
            }
            for(int i = 0; i < td.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Задание: {td[i].Title}, статус: {td[i].IsDone}");
            }
            Console.WriteLine("Введите порядковый номер задачи, чтобы отметить ее как выполненную");
            int t = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < td.Length; i++)
            {
                if((i+1) == t)
                {
                    td[i].IsDone = "Выполнено";
                }
                Console.WriteLine($"{i + 1}. Задание: {td[i].Title}, статус: {td[i].IsDone}");
                ToDo[] newList = new ToDo[]
                {
                    new ToDo() {Title = $"{td[i].Title}", IsDone = $"{td[i].IsDone}"},
                };
                string newTd = JsonSerializer.Serialize<ToDo[]>(newList);
                File.AppendAllText("newList.json", newTd);
            }
        }
    }
}
