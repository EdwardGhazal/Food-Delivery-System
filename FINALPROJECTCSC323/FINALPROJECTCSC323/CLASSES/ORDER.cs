using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FINALPROJECTCSC323.CLASSES;

namespace FINALPROJECTCSC323.NewFolder;

public class ORDER
{
    public DateTime OrderDate { get; set; }
    public ORDERSTATUS OrderStatus { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public INVOICE? Invoice { get; set; }
    public List<ORDERDETAIL> OrderDetails { get; set; } = new List<ORDERDETAIL>();
    public ADDRESS? Address { get; set; }

    public IDELIVERY? Delivery;


    public ORDER(DateTime orderDate, ORDERSTATUS status, decimal totalAmount, decimal discountAmount, INVOICE invoice, List<ORDERDETAIL> orderdetails, ADDRESS address)
    {
        OrderDate = orderDate;
        OrderStatus = status;
        TotalAmount = totalAmount;
        DiscountAmount = discountAmount;
        Invoice = invoice;
        OrderDetails = orderdetails;
        Address = address;
    }

    public ORDER() { }


    public void AddOrderDetail(ORDERDETAIL detail)
    {
        OrderDetails.Add(detail);
    }

    public void RemoveOrderDetail(ORDERDETAIL detail)
    {
        OrderDetails.Remove(detail);
    }

    public void FinalizeOrder()
    {
        OrderDate = DateTime.Now;
        OrderStatus = ORDERSTATUS.Pending;

        foreach (ORDERDETAIL detail in OrderDetails)
        {
            TotalAmount += detail.Subtotal;
        }

        TotalAmount = TotalAmount - TotalAmount * DiscountAmount;

    }

    public void ApplyDiscount(decimal discountPercent)
    {
        DiscountAmount = discountPercent;
    }
    public void SetDelivery(IDELIVERY Delivery)
    {
        this.Delivery = Delivery;
    }

    public string Deliver()
    {
        return Delivery?.Deliver()??"";
    }


}


