using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab4.Concrete
{
    public class ArasKargo
    {
        public ArasKargo(INakliye nakliye) : base(nakliye)
        {

        }
        public override void NakliyeBaslat()
        {
            Console.WriteLine("Aras kargo ıgdırdan esyalari yukledi");
            nakliye.
        }

    }
}
