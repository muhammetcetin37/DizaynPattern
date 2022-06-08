using MediatorPattern.Lab2.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab2.Abstract
{
    public abstract class AssingnedCourseMember
    {
        private readonly CoreMediator coreMediator;

        public AssingnedCourseMember(CoreMediator coreMediator )
        {
            this.coreMediator = coreMediator;
        }
    }
}
