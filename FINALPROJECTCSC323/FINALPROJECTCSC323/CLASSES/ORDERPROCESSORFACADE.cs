using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECTCSC323.NewFolder;

public class ORDERPROCESSORFACADE
{
    private static ORDERPROCESSORFACADE? instance;
    private ORDERPROCESSORFACADE() { }

    public static ORDERPROCESSORFACADE GetInstance()
    {
        if (instance == null)
        {
            instance = new ORDERPROCESSORFACADE();
        }

        return instance;
    }
    public void ProcessOrder(ORDER order, CUSTOMER customer, RESTAURANT restaurant, PAYMENTMETHOD paymentMethod, INOTIFICATION notification)
    {
        
        order.FinalizeOrder();

        
        INVOICE invoice = new INVOICE
        {
            CustomerName = customer.GetFullName(),
            RestaurantName = restaurant.RestaurantName,
            IssueDate = DateTime.Now,
            TotalAmount = order.TotalAmount,
            DiscountAmount = order.DiscountAmount,
        };

        foreach (ORDERDETAIL detail in order.OrderDetails)
        {
            INVOICELINE line = new INVOICELINE(detail.item.MenuItemName, detail.Quantity, detail.UnitPrice);

            invoice.AddInvoiceLine(line);
        }

        PAYMENT payment = new PAYMENT(paymentMethod);
        invoice.Payment = payment;

        invoice.CalculateFinalAmount();
        order.Invoice = invoice;

        notification.SendNotification(customer);
        MessageBox.Show(order.Deliver());


        customer.AddOrder(order);
    }

}


