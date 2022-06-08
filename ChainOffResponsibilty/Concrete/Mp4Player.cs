using ChainOffResponsibility.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOffResponsibility.Concrete
{
    public class Mp4Player : PlayerHandler
    {
        public override void Player(string fileType)
        {
            if (fileType.EndsWith(".mp4"))
            {
                Console.WriteLine($"{fileType}tipinde medya oynatiliyor.");
            }
            else
            {
                Console.WriteLine("Geçersiz Dosya Bicimi");
            }
        }
    }
}
