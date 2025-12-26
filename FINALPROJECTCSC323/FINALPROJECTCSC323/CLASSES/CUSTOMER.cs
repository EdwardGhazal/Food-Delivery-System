using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECTCSC323.NewFolder;

public class CUSTOMER : USER
{
    public List<ORDER> Orders { get; set; } = new List<ORDER>();
    public ADDRESS Address { get; set; } =new ADDRESS(); 

    public CUSTOMER(string firstName, string lastName, string email, string phoneNumber)
        : base(firstName, lastName, email, phoneNumber)
    {

    }

    public override string GetFullName()
    {
        return $"{LastName}, {FirstName}";
    }

    public void AddOrder(ORDER newOrder)
    {
        newOrder.OrderStatus = ORDERSTATUS.Delivered;
        Orders.Add(newOrder);
    }
}
