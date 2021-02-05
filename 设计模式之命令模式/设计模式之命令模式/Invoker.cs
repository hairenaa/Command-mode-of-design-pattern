using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式之命令模式
{
    class Invoker
    {
       private Queue<ICommand> commandQue = new Queue<ICommand>();

        internal Queue<ICommand> CommandQue
        {
            get
            {
                return commandQue;
            }

        }

        public void AddToCommandQueue(ICommand com)
        {
            CommandQue.Enqueue(com);

        }

        private void RemoveTopCommand()
        {
            CommandQue.Dequeue();
        }


        public void RemoveAllCommand()
        {
            commandQue.Clear();

        }

        public void ExcuteCommand()
        {
            int count = commandQue.Count;
            for (int i = 0; i <count ; i++)
            {
                commandQue.First().Excute();
                RemoveTopCommand();
            }

        }


    }
}
