using MediatorPattern.Lab2.Mediator;

namespace MediatorPattern.Lab2.Concrete
{
    public class AssingnedCoursMember
    {
        private CoreMediator coreMediator;

        public AssingnedCoursMember(CoreMediator coreMediator)
        {
            this.coreMediator = coreMediator;
        }
    }
}