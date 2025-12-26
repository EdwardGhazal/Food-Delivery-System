using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FINALPROJECTCSC323.NewFolder;

public class RESTAURANT
{
    public string RestaurantName { get; set; }
    public MENU Menu { get; set; }

    public RESTAURANT(string name, MENU menu)
    {
        RestaurantName = name;
        Menu = menu;
    }
}
