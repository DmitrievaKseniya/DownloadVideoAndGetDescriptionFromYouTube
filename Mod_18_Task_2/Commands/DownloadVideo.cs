using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_18_Task_2.Commands
{
    class DownloadVideo : Command
    {
        Receiver receiver;
        string urlVideo;
        public DownloadVideo(Receiver receiver, string urlVideo)
        {
            this.receiver = receiver;
            this.urlVideo = urlVideo;
        }
        public override void Run()
        {

        }
    }
}
