using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Work.QA_Work.Menu.MenuLogic;

internal class MenuOptions
{
    // Название опции в меню
    public string? Title { get; set; }

    // Действие, которое выполняется при выборе опции
    public Action? OpenOperation { get; set; }
}
