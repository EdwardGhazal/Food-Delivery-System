using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECTCSC323.NewFolder;

public class CART
{

    public ORDER Order { get; set; } = new ORDER();

    public void AddItem(ORDERDETAIL detail)
    {
        Order.AddOrderDetail(detail);
    }

    public void RemoveItem(ORDERDETAIL detail)
    {

        Order.RemoveOrderDetail(detail);
    }

    public void PlaceOrder(CUSTOMER customer, RESTAURANT restaurant, PAYMENTMETHOD paymentMethod, INOTIFICATION notification)
    {

        ORDERPROCESSORFACADE orderProcessor=ORDERPROCESSORFACADE.GetInstance();


        orderProcessor.ProcessOrder(Order, customer, restaurant, paymentMethod, notification);



        Order = new ORDER();


    }

}
