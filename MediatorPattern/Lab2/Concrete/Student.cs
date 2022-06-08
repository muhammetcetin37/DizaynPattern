
using MediatorPattern.Lab2.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab2.Concrete
{
    public class Student : AssingnedCoursMember
    {
        public Student(CoreMediator coreMediator) : base(coreMediator)
        {

        }
        public string Name { get; set; }
        public void SendQuestion(string message)
        {
            Console.WriteLine($"{Name}:{message}");
        }
        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Student receive answer:{message}");
        }
    }
}
