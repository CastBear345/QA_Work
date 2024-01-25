using QA_Work.QA_Work.Menu;
using QA_Work.QA_Work.Menu.MenuLogic;
using System;
using System.Text;

public class Program
{
    public static void Main()
    {

        // Вывод на экран приглашения к выбору калькулятора
        Console.WriteLine("Выберите калькулятор: ");

        // Вывод меню с первоначальными действиями
        ShowMenu.ShowFirstActions();
    }
}
