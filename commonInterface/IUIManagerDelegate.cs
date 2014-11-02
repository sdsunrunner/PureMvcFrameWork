using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using frameWork.view.viewInterface;

namespace frameWork.commonInterface
{
    interface IUIManagerDelegate
    {
        void addPanel(IViewController viewController, String viewType);

        void createPanel(IViewController viewController, String viewType);

        void removePanel(IViewController viewController, String viewType);
    }
}
