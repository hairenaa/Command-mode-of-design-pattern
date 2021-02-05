using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式之命令模式
{
    class ChangeChanalCommand : Command, ICommand
    {
        public void Excute()
        {
            ChangeChanalMethod(Msg);
        }
        public ChangeChanalCommand(CommandMsg? msg = default(CommandMsg?)) 
        {
            base.Msg = msg;

        }



        private void ChangeChanalMethod(CommandMsg? msg = default(CommandMsg?))
        {
            TV.ChangeChanal(msg);
        }

    }
}
