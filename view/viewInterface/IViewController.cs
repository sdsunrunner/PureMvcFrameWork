using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using frameWork.commonInterface;
namespace frameWork.view.viewInterface
{
    interface IViewController : INotifier,IDispose
    {
        IView getView();
    }
}
