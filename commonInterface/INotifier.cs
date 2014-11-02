using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace frameWork.commonInterface
{
    interface INotifier
    {
        void sendNotification(String notificationName,Object data);
    }
}
