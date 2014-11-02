using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using frameWork.command.cmdInterface;

namespace frameWork.command
{
    class BaseNotification : INotification
    {
        private Object _data = null;      

        public object data
        {
            get
            {
                return this._data;
            }
            set 
            {
                this._data = value;
            }
        }
    }
}
