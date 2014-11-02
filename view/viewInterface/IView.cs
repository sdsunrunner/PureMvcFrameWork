using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace frameWork.view.viewInterface
{
    interface IView : IObserver
    {
        void initModel();
    }
}
