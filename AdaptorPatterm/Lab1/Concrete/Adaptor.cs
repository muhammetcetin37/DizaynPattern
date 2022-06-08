using AdaptorPatterm.Lab1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPatterm.Lab1.Concrete
{
    public class Adaptor:Uyarlayici,ITarget
    {
        public string Request(int i)
        {
            return $"Tahmini Sonuc:{Math.Round(SpecialRequest(i, 3))}";
        }
    }
}
