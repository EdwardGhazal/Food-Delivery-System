using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECTCSC323.NewFolder;

public class SMSNOTIFICATION : INOTIFICATION
{
    public void SendNotification(CUSTOMER SMS)
    {
        MessageBox.Show($"SMS was sent to {SMS.PhoneNumber} .");
    }
}
