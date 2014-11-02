using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using frameWork.command.cmdInterface;

namespace frameWork.command
{
    class SuperCommand : ICommand
    {
        public virtual void excute(INotification note)
		{
			
		}

        public void notify(String typeStr, Object data = null)
		{
            BaseNotification notification = new BaseNotification();
            notification.data = data;

            AppNotification note = new AppNotification(typeStr, notification);
			
			note.dispatch();
		}
    }
}
