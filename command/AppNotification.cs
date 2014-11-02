using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using frameWork.command.cmdInterface;
using frameWork.facade;

namespace frameWork.command
{
    class AppNotification
    {
        private String _commandType = "";
        private INotification _note = null;
        private AppFacade _appCenter = AppFacade.instance;

        public AppNotification(String commandType, INotification note)
		{
			_commandType = commandType;
			_note = note;
		}	

        public void dispatch()
		{
			if(_appCenter.hasCommand(_commandType))
			{
				ICommand command = _appCenter.instanceCommandByType(_commandType);
				command.excute(_note);
			}
			else
			{                 
				throw new Exception("command " + _commandType + " has not been registed!");
			}
		}
    }
}
