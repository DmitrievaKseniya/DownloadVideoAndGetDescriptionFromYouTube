using Mod_18_Task_2.Commands;

namespace Mod_18_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ссылку на видео на YouTube:");
            string url = Console.ReadLine();

            var sender = new Sender();
            var receiver = new Receiver();

            var getDescription = new GetDescriptionVideo(receiver, url);
            sender.SetCommand(getDescription);
            sender.Run();
        }
    }
}