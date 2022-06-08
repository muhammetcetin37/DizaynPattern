﻿using MediatorPattern.Lab1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab1.Mediator.Abstract
{
   public interface IChatMediator
    {
         void AddUser(IUser user);
        void SendMessage(string message, IUser sender);
    }
}
