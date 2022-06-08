using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab4.Concrete
{
    internal class MngKargo
    {
        public class MngKargo(INakliye nakliye) : base (nakliye)
        {

        }
    }
}
