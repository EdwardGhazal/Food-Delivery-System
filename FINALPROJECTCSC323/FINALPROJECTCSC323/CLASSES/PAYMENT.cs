using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECTCSC323.NewFolder;

public class PAYMENT
{
    public PAYMENTMETHOD PaymentMethod { get; set; }
    public DateTime PaymentDate { get; set; }

    public PAYMENT(PAYMENTMETHOD method)
    {
        PaymentMethod = method;
        PaymentDate = DateTime.Now;
    }

}
