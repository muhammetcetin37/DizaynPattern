using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab4.Concrete
{
    public class YurticiKargo : Firma
    {
        public YurticiKargo(INakliye nakliye) : base(nakliye)
        {

        }
        public override void NakliyeBaslat()
        {
            Console.WriteLine("Ankaradan Kargoya yüklendi");
            
        }
    }
}
