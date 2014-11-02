using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace frameWork.command.cmdInterface
{
    interface ICommand
    {
        void excute(INotification note);
    }
}
