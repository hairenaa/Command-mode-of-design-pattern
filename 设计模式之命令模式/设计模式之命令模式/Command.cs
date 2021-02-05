using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式之命令模式
{
    class Command
    {
        protected static Television TV
        {
            get;
            set;
        }

        protected CommandMsg? Msg
        {
            get;
            set;
        }
        public Command()
        {
            
            TV = new Television();
        }

    }
}
