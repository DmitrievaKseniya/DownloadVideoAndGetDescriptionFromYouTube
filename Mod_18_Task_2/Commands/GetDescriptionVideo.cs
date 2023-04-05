using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Mod_18_Task_2.Commands
{
    class GetDescriptionVideo : Command
    {
        Receiver receiver;
        string urlVideo;
        public GetDescriptionVideo(Receiver receiver, string urlVideo)
        {
            this.receiver = receiver;
            this.urlVideo = urlVideo;
        }
        public override async void Run()
        {
            var youtube = new YoutubeClient();

            var video = await youtube.Videos.GetAsync(urlVideo);
            Console.WriteLine($"Название видео: {video.Title}");
            Console.WriteLine($"Название канала: {video.Author.Title}");
            Console.WriteLine($"Длительность видео: {video.Duration}");
            receiver.Operaton();
        }
    }
}
