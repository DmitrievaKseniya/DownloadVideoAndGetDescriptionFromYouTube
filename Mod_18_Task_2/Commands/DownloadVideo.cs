using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

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
            Console.WriteLine("\nНачалось скачивание видео!");
            var youtube = new YoutubeClient();
            var video = youtube.Videos.GetAsync(urlVideo).Result;

            string nameVideo = $"{video.Title}.mp4";

            youtube.Videos.DownloadAsync(urlVideo, nameVideo, builder => builder.SetPreset(ConversionPreset.UltraFast)).AsTask().Wait();
            receiver.Operaton($"Видео скачано в файл: {nameVideo}");
        }
    }
}
