using System;
using System.Text;
using QA_Work.QA_Work.Menu.MenuLogic;

namespace QA_Work.QA_Work.Menu;

public class Calculator
{
    // Метод для начала работы с калькулятором
    public static void Start()
    {
        char choice;
        bool isTrue = true;

        // Цикл, позволяющий пользователю выполнять вычисления до тех пор, пока isTrue равно true
        do
        {
            Console.Clear();
            Console.Write("Желаете выполнить еще одно вычисление? (Y/N): ");

            // Считывание символа с клавиатуры
            choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Проверка наличия согласия пользователя (Y или y)
            if (choice == 'д' || choice == 'Д' || choice == 'y' || choice == 'Y')
            {
                // В случае согласия отображается первое меню

                isTrue = false;
                ShowMenu.ShowFirstActions();
            }
            else
            {
                // В случае отказа выполняется следующая итерация цикла
                isTrue = true;
                continue;
            }

        } while (isTrue == true);
    }
}