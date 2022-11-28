using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class EmailSender
    {
        private void ConnectionToSmtpServer()
        {
            Console.WriteLine("connecting to server");
        }

        private void InsertCredentials()
        {
            Console.WriteLine("Inserting credentials");
        }

        public void SendEmail(string tile, string body, string to)
        {
            ConnectionToSmtpServer();
            Console.WriteLine("Inserting credentials");
            Console.WriteLine($"Sending to:{to} message {body} to {to}");
            Disconnet();
        }

        private void Disconnet()
        {
            Console.WriteLine($"Disconnected from the server");
        }
    }
}



