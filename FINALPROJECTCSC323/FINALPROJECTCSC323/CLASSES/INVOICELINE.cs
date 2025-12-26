using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECTCSC323.NewFolder;

public class INVOICELINE
{
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Subtotal => Quantity * UnitPrice;

    public INVOICELINE(string itemName, int quantity, decimal unitPrice)
    {
        ItemName = itemName;
        Quantity = quantity;
        UnitPrice = unitPrice;

    }

}
