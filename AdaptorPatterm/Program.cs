using AdaptorPatterm.Lab1.Abstract;
using AdaptorPatterm.Lab1.Concrete;
using System;

namespace AdaptorPatterm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Uyarlayici uyarlayici = new Uyarlayici();
            Console.WriteLine(uyarlayici.SpecialRequest(5,3));

            ITarget target = new Adaptor();

            Console.WriteLine(target.Request(5));

            Console.WriteLine("Hello World!");
        }
    }
}
