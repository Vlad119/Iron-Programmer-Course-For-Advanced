using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SendNotification(message: "Новое сообщение");
            SendNotification(message: "Новое сообщение", sound: "ping");
            SendNotification(message: "Важно!", isUrgent: true);
            SendNotification(message: "Важно!", "ping", isUrgent: true);
        }

        static void SendNotification(string message, string sound = "default", bool isUrgent = false)
        {
            Console.WriteLine($"Получено сообщение {message}, оно воспроизведено со звуком {sound} и параметр срочности равен {isUrgent}");
        }
    }
}