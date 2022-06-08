using MediatorPattern.Lab1.Abstract;
using MediatorPattern.Lab1.Mediator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab1.Concrete
{
    public class BasicUser : IUser
    {
        string username;
        IChatMediator chatMediator;

        public BasicUser(IChatMediator chatMediator, string username)
        {
            this.chatMediator = chatMediator;
            this.username = username;
        }
        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Kullanici Tipi:Basic\nKullanici Adi:{username}\nAlinan Mesaj:{message}");
        }

        public void SendMessage(string message)
        {
            chatMediator.SendMessage(message, this);
           
        }
    }
}
