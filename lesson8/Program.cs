using System;
using System.Configuration;


namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Создать консольное приложение, которое при старте выводит приветствие, записанное в настройках
            приложения(application - scope).Запросить у пользователя имя, возраст и род деятельности, а затем
            сохранить данные в настройках.При следующем запуске отобразить эти сведения. Задать
            приложению версию и описание.
            */

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings["UserName"].Value == null && config.AppSettings.Settings["UserAge"].Value == null 
                && config.AppSettings.Settings["Interests"].Value == null)
            {
                Console.WriteLine("Введите свое имя");
                var name = Console.ReadLine();
                Console.WriteLine("Введите свой возраст");
                var age = Console.ReadLine();
                Console.WriteLine("Введите свой род деятельности");
                var interests = Console.ReadLine();
                config.AppSettings.Settings["UserName"].Value = name;
                config.AppSettings.Settings["UserAge"].Value = age;
                config.AppSettings.Settings["Interests"].Value = interests;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            Console.WriteLine($"Приветствую {config.AppSettings.Settings["UserName"].Value}, " +
            $"ваш возраст {config.AppSettings.Settings["UserAge"].Value}, " +
            $"ваш интерес {config.AppSettings.Settings["Interests"].Value}");
        }
    }
}