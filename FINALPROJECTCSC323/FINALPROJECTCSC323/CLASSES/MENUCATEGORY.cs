using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECTCSC323.NewFolder;

public class MENUCATEGORY
{

    public string MenuCategoryName { get; set; }
    public List<MENUITEM> MenuItems { get; set; }

    public MENUCATEGORY(string categoryName, List<MENUITEM> menuItems)
    {
        MenuCategoryName = categoryName;
        MenuItems = menuItems;

    }
}
