using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECTCSC323.NewFolder;

public class ORDERDETAIL
{
    public MENUITEM item { get; set; }

    public int Quantity { get; set; }
    public decimal Subtotal => Quantity * UnitPrice;
    public decimal UnitPrice { get; set; }
    public ORDERDETAIL(MENUITEM item, int quantity)
    {
        this.item = item;
        Quantity = quantity;
        UnitPrice = item.Price;
    }

}