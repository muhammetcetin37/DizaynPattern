using MediatorPattern.Lab2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab2.Mediator
{
    public class CoreMediator
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
     

        public void MediatorSendQuestion(string question, Student student)
        {
            Teacher.ReceiveQuestion(question, student);
        }
        public void MediatorSendAnswer(String answer, Student student) => Console.WriteLine($"");
    }
}
