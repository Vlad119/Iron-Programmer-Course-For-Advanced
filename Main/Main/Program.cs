using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string server = "example.com";
            int port = 9000;
            int timeout = 60;
            Connect(server: server); 
            Connect(server: server, port: port);
            Connect(server: server, port: port, timeout: timeout); 
        }

        static void Connect(string server, int port = 8080, int timeout = 30)
        {
            Console.WriteLine($"Подключение к {server}:{port}, Таймаут: {timeout} сек");
        }
    }
}