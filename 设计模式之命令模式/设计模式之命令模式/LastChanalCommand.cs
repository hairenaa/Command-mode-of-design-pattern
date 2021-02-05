using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式之命令模式
{
    class LastChanalCommand : Command, ICommand
    {
        public void Excute()
        {
            LastChanalMethod();
        }

        private void LastChanalMethod()
        {

            TV.LastChanal();
        }
    }


}
