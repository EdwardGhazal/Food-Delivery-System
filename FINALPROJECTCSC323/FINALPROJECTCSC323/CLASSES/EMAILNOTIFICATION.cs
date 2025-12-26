using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECTCSC323.NewFolder;

public class EMAILNOTIFICATION : INOTIFICATION
{
    public void SendNotification(CUSTOMER email)
    {
        MessageBox.Show($"Email was send to {email.Email}");
    }
}
