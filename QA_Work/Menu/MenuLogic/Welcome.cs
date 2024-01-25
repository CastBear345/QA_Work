using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Work.QA_Work.Menu.MenuLogic
{
    internal class Welcome
    {
        // Метод, выполняющий приветственное сообщение, ожидание 1 секунды и очистку консоли
        public static void Start()
        {
            Console.WriteLine("Welcome!");
            Thread.Sleep(1000);
            Console.Clear();
        }

        // Метод, выполняющий очистку консоли, вывод прощального сообщения и завершение программы
        public static void Stop()
        {
            Console.Clear();
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
        }
    }
}
