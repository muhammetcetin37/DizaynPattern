using ChainOffResponsibility.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOffResponsibility.Concrete
{
    public class AviPlayer : PlayerHandler
    {
        public override void Player(string fileType)
        {
            if (fileType.EndsWith(".avi"))
            {
                Console.WriteLine($"{fileType}tipinde medya oynatiliyor.");
            }
            else
            {
                if (_nextHandler != null)
                {
                    _nextHandler.Player(fileType);
                }
            }
        }
    }
}
