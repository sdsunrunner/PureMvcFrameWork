using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace frameWork.view.viewInterface
{
    interface IMessageCenter
    {
        /*
        *  注册为观察者    
        */
        void register(IObserver observer);
        
        /*
         * 取消注册 
         */
        void unRegister(IObserver observer);

        /*
         * 取消所有观察者 
         */
        void unRegisterAll();

        /*
         * 发送消息
         */
        void notify();
    }
}
