using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECTCSC323.NewFolder;

public class MENUITEM
{
    public string MenuItemName { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public MENUITEM(string menuItemName, string description, decimal price)
    {
        MenuItemName = menuItemName;
        Description = description;
        Price = price;
    }
}