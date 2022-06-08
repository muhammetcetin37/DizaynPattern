using MediatorPattern.Lab1.Abstract;
using MediatorPattern.Lab1.Concrete;
using MediatorPattern.Lab1.Mediator.Abstract;
using MediatorPattern.Lab1.Mediator.Concrete;
using MediatorPattern.Lab2.Concrete;
using MediatorPattern.Lab2.Mediator;
using System;
using System.Collections.Generic;

namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region lab1
            //IChatMediator mediator = new ChatMediator();
            //IUser Ali = new BasicUser(mediator, "Ali");
            //IUser Veli = new BasicUser(mediator, "Veli");
            //IUser Ayse = new BasicUser(mediator, "Ayse");
            //IUser Fatma = new BasicUser(mediator, "Fatma");

            //mediator.AddUser(Ali);
            //mediator.AddUser(Veli);
            //mediator.AddUser(Ayse);
            //mediator.AddUser(Fatma);
            //Ali.SendMessage("Herkese Merhaba");
            //Ayse.SendMessage("Selam Ali, nasilsin");

            #endregion
            #region lab2
            CoreMediator coreMediator = new CoreMediator();
            Teacher teacher = new Teacher(coreMediator);
            teacher.Name = "Ercan";

            Student Arif = new Student(coreMediator);
            Arif.Name = "Arif";
            Student Emir = new Student(coreMediator);
            Emir.Name = "Emir";

            coreMediator.Students = new List<Student>();
            coreMediator.Students.Add(Arif);
            coreMediator.Students.Add(Emir);

            Arif.SendQuestion("Hocam bu $ işaretini niçin kullaniyoruz ben TL kullanmak istiyorum");
            teacher.AnswerQuestion("Parayi veren dudugu calar arif.. Buralarda TL Geçmez.", Arif);

            Emir.SendQuestion("Hocam bu Pattern nasildir..");
            teacher.AnswerQuestion("sabahlari kahvaltıdan sonra iyi gider",Emir);
            #endregion
        }
    }
}
