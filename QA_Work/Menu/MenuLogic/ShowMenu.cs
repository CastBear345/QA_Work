using System;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Tasks;

namespace QA_Work.QA_Work.Menu.MenuLogic;

internal class ShowMenu
{
    // Метод для отображения первоначальных действий из списка Options3
    public static void ShowFirstActions()
    {
        List<MenuOptions> list = MenuList.Options3;
        ShowAllActions(list);
    }

    // Метод для отображения вторичных действий из списка Options
    public static void ShowSecondActions()
    {
        List<MenuOptions> list = MenuList.Options;
        ShowAllActions(list);
    }

    // Метод для отображения третичных действий из списка Options2
    public static void ShowThirdActions()
    {
        List<MenuOptions> list = MenuList.Options2;
        ShowAllActions(list);
    }

    // Метод для отображения всех действий в меню
    private static void ShowAllActions(List<MenuOptions> menu)
    {
        ConsoleKeyInfo keyInfo;
        List<MenuOptions> optionsCount = menu;
        int indexTab = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("Выберите: ");

            // Отображение всех опций меню с выделением текущей выбранной опции
            for (int optionNumber = 0; optionNumber < optionsCount.Count; optionNumber++)
            {
                if (optionNumber == indexTab)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;

                    // Дополнительное выделение для определенной опции (indexTab == 4)
                    if (indexTab == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                }

                Console.WriteLine();
                Console.WriteLine(optionsCount[optionNumber].Title);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }

            keyInfo = Console.ReadKey(true);

            // Обработка клавиш вверх и вниз для перемещения по меню
            if (keyInfo.Key == ConsoleKey.UpArrow) { indexTab = (indexTab - 1 + optionsCount.Count()) % optionsCount.Count(); }
            if (keyInfo.Key == ConsoleKey.DownArrow) { indexTab = (indexTab + 1) % optionsCount.Count(); }

            // Обработка клавиши Enter для выполнения выбранной опции
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                optionsCount[indexTab].OpenOperation();
            }
            // Обработка клавиши Escape для выхода из меню
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("The End!");
            }

        } while (keyInfo.Key != ConsoleKey.Escape);
    }
}