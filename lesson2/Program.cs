using System;
using System.Globalization;

namespace lesson2
{
    class Program
    {
        [Flags]
        public enum list
        {
            monday = 0b_0000001,
            tuesday = 0b_0000010,
            wednesday = 0b_0000100,
            thursday = 0b_0001000,
            friday = 0b_0010000,
            saturday = 0b_0100000,
            sunday = 0b_1000000,
        }
        static void Main(string[] args)
        {
            /*
            1. Запросить у пользователя минимальную и максимальную температуру за сутки и 
            вывести среднесуточную температуру.
            */

            Console.WriteLine("Введите максимальную температуру за сегодня");

            int max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите миниальную температуру за сегодня");

            var min = Convert.ToInt32(Console.ReadLine());

            var ave = (max + min) / 2;

            Console.WriteLine($"Максимальная температура: {max}, минимальная {min}, среднесуточная {ave}");
            
            /*
             2. Запросить у пользователя порядковый номер текущего месяца и вывести его название.
             */

            Console.WriteLine("Введите номер месяца");

            var num = Convert.ToInt32(Console.ReadLine());

            var date = new DateTime(2021, num, 1);

            Console.WriteLine(date.ToString("MMMM"));

            /*
             3. Определить, является ли введённое пользователем число чётным.
             */

            Console.WriteLine("Введите число");

            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine($"Число {a} - четное");
            }
            else
            {
                Console.WriteLine($"Число {a} - нечетное");
            }

            /*
            4. Для полного закрепления понимания простых типов найдите любой чек, либо фотографию
            этого чека в интернете и схематично нарисуйте его в консоли, только за место динамических, 
            по вашему мнению, данных (это может быть дата, название магазина, сумма покупок)
            подставляйте переменные, которые были заранее заготовлены до вывода на консоль.
            */

            int number1, number2, number3;

            double cost1, cost2, cost3, end1, end2, end3, end4, end5, end6;

            string name1, name2, name3, text1, text2, text3, text4, text5, text6, text7;

            number1 = 1; number2 = 2; number3 = 3;

            cost1 = 19.90; cost2 = 81.50; cost3 = 20.62;

            end1 = 122.02; end2 = 0.02; end3 = 122; end4 = 125; end5 = 3; end6 = 122;

            name1 = "Молоко"; name2 = "Колбаса"; name3 = "Бананы";

            text1 = "Итого без скидок: "; text2 = "Итого скидок: "; text3 = "Итого: ";

            text4 = "Внесено: "; text5 = "Сдача: "; text6 = "Наличные: "; text7 = "Спасибо за покупку!";

            Console.WriteLine($"{number1}      {name1}       {cost1}" + "\n" + 
                                $"{number2}      {name2}      {cost2}" + "\n" +
                                $"{number3}      {name3}       {cost3}" + "\n" + "\n" +
                                $"{text1}  {end1}" + "\n" +
                                $"{text2}      {end2}" + "\n" +
                                $"{text3}             {end3}" + "\n" +
                                $"{text4}           {end4}" + "\n" +
                                $"{text5}             {end5}" + "\n" +
                                $"{text6}          {end6}" + "\n" + "\n" +
                                $"   {text7}"); 
            /*
             5.  (*)Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести
             сообщение «Дождливая зима».
            */ 

            Console.WriteLine("Введите максимальную температуру сегодня");

            int maxTemp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите минимальную температуру сегодня");

            int minTemp = Convert.ToInt32(Console.ReadLine());

            int aveTemp = (maxTemp + minTemp) / 2;

            Console.WriteLine("Укажите месяц");

            int newMonth = Convert.ToInt32(Console.ReadLine());

            DateTime dateMonth = new DateTime(2021, newMonth, 1);

            Console.WriteLine(dateMonth.ToString("MMMM"));

            if(newMonth == 12 || newMonth == 1 || newMonth == 2 && aveTemp > 0 )
            {
                Console.WriteLine("Дождливая зима");
            }
            else
            {
                Console.WriteLine("Обычная зима");
            }

            /*
            6. (*) Для полного закрепления битовых масок, попытайтесь создать универсальную структуру
            расписания недели, к примеру, чтобы описать работу какого либо офиса. Явный пример -
            офис номер 1 работает со вторника до пятницы, офис номер 2 работает с понедельника до
            воскресенья и выведите его на экран консоли.
            */

            list office1 = (list)0b0011110;

            list office2 = (list)0b0111111;

            Console.WriteLine($"Работа первого офиса: {office1}" +"\n"+ $"Работа второго офиса: {office2}");

            //7. **Развернуть число

            Console.WriteLine("Введите строку");

            int number = Convert.ToInt32(Console.ReadLine());

            int res = 0;

            while (number > 0)
            {
                res *= 10;
                res += number % 10;
                number /= 10;
            }
            Console.WriteLine(res);
        }
    }
}
