using MediatorPattern.Lab2.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab2.Concrete
{
    public class Teacher:AssingnedCoursMember
    {
        public Teacher(CoreMediator mediator) : base(mediator) { }
        public string Name { get; set; }
        public void ReceiveQuestion(string question, Student student) 
            => Console.WriteLine($"Teacher receive question from{student.Name},{question}");
        public void AnswerQuestion(string question, Student student)
            => Console.WriteLine($"Teacher answer question from{student.Name},{question}");

    }
}
