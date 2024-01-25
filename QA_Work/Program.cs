using QA_Work.QA_Work.Menu;
using QA_Work.QA_Work.Menu.MenuLogic;
using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        // Приветственное сообщение и запуск программы
        Welcome.Start();

        // Вывод на экран приглашения к выбору калькулятора
        Console.WriteLine("Выберите калькулятор: ");

        // Вывод меню с первоначальными действиями
        ShowMenu.ShowFirstActions();
    }
}
