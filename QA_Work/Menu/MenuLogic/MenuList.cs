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
            Title = "Add",
            OpenOperation = Addition.ShowAddResults
        },
        new MenuOptions()
        {
            Title = "Subtract",
            OpenOperation = Substract.ShowExtractResults
        },
        new MenuOptions()
        {
            Title = "Multiply",
            OpenOperation = Multiply.ShowMultiplyResults
        },
        new MenuOptions()
        {
            Title = "Divide",
            OpenOperation = Divide.ShowDivisionResults
        },
        new MenuOptions()
        {
            Title = "Exit",
            OpenOperation = Welcome.Stop
        },
    };

    // Список опций для кастомного калькулятора
    public static List<MenuOptions> Options2 = new List<MenuOptions>()
    {
        new MenuOptions()
        {
            Title = "Add",
            OpenOperation = BigInteger.PerformAdd
        },
        new MenuOptions()
        {
            Title = "Subtract",
            OpenOperation = BigInteger.PerformSubstract
        },
        new MenuOptions()
        {
            Title = "Multiply",
            OpenOperation = BigInteger.PerformMultiply
        },
        new MenuOptions()
        {
            Title = "Divide",
            OpenOperation = BigInteger.PerformDivide
        },
        new MenuOptions()
        {
            Title = "Exit",
            OpenOperation = Welcome.Stop
        },
    };

    // Список опций для выбора между обычным калькулятором и калькулятором с использованием System.Numerics.BigInteger
    public static List<MenuOptions> Options3 = new List<MenuOptions>()
    {
        new MenuOptions()
        {
            Title = "System BigInteger",
            OpenOperation = ShowMenu.ShowSecondActions
        },
        new MenuOptions()
        {
            Title = "Other BigInteger",
            OpenOperation = UserInterface.PerformCalculatorOperations
        },
        new MenuOptions()
        {
            Title = "Exit",
            OpenOperation = Welcome.Stop
        },
    };
}
