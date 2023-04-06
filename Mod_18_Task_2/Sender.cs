using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod_18_Task_2.Commands;

namespace Mod_18_Task_2
{
    class Sender
    {
        private Command _command;
        public void SetCommand(Command command)
        {
            _command = command;
        }

        public async void Run()
        {
           _command.Run();
        }
    }
}
