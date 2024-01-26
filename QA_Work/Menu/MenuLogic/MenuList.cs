using QA_Work.BI_Calculate;
using QA_Work.BI;

namespace QA_Work.QA_Work.Menu.MenuLogic;

internal class MenuList
{
    // Список опций для калькулятора с использованием System.Numerics.BigInteger
    public static List<MenuOptions> Options = new List<MenuOptions>()
    {
        new MenuOptions()
        {
            Title = "╔               ╗\n"
                  + "       Add       \n"
                  + "╚               ╝\n",
            Open = Addition.ShowAddResults
        },
        new MenuOptions()
        {
            Title = "╔               ╗\n"
                  + "     Subtract    \n"
                  + "╚               ╝\n",
            Open = Substract.ShowExtractResults
        },
        new MenuOptions()
        {
            Title = "╔               ╗\n"
                  + "     Multiply    \n"
                  + "╚               ╝\n",
            Open = Multiply.ShowMultiplyResults
        },
        new MenuOptions()
        {
            Title = "╔               ╗\n"
                  + "      Divide     \n"
                  + "╚               ╝\n",
            Open = Divide.ShowDivisionResults
        },
        new MenuOptions()
        {
            Title = "╔               ╗\n"
                  + "       Exit      \n"
                  + "╚               ╝\n",
            Open = Welcome.Stop
        },
    };

    // Список опций для кастомного калькулятора
    public static List<MenuOptions> Options2 = new List<MenuOptions>()
    {
        new MenuOptions()
        {
            Title = "╔               ╗\n"
                  + "       Add       \n"
                  + "╚               ╝\n",
            Open = BigInteger.PerformAdd
        },
        new MenuOptions()
        {
            Title = "╔               ╗\n"
                  + "     Subtract    \n"
                  + "╚               ╝\n",
            Open = BigInteger.PerformSubstract
        },
        new MenuOptions()
        {
            Title = "╔               ╗\n"
                  + "     Multiply    \n"
                  + "╚               ╝\n",
            Open = BigInteger.PerformMultiply
        },
        new MenuOptions()
        {
            Title = "╔               ╗\n"
                  + "      Divide     \n"
                  + "╚               ╝\n",
            Open = BigInteger.PerformDivide
        },
        new MenuOptions()
        {
            Title = "╔               ╗\n"
                  + "       Exit      \n"
                  + "╚               ╝\n",
            Open = Welcome.Stop
        },
    };

    // Список опций для выбора между обычным калькулятором и калькулятором с использованием System.Numerics.BigInteger
    public static List<MenuOptions> Options3 = new List<MenuOptions>()
    {
        new MenuOptions()
        {
            Title = "╔                  ╗\n"
                  + "  System BigInteger \n"
                  + "╚                  ╝\n",
            Open = ShowMenu.ShowSecondActions
        },
        new MenuOptions()
        {
            Title = "╔                  ╗\n"
                  + "  Custom BigInteger \n"
                  + "╚                  ╝\n",
            Open = UserInterface.PerformCalculatorOperations
        },
        new MenuOptions()
        {
            Title = "╔               ╗\n"
                  + "       Exit      \n"
                  + "╚               ╝\n",
            Open = Welcome.Stop
        },
    };
}
