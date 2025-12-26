using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECTCSC323.NewFolder;

public class MENU
{
    public string MenuName { get; set; }
    public List<MENUCATEGORY> MenuCategories { get; set; } = new List<MENUCATEGORY>();

    public MENU(string name, List<MENUCATEGORY> menucategories)
    {
        MenuName = name;
        MenuCategories = menucategories;


    }

}
