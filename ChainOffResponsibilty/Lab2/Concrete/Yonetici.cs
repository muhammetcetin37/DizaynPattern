﻿using ChainOffResponsibility.Lab2.Abstract;
using ChainOffResponsibility.Lab2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOffResponsibility.Lab2.Concrete
{
    public class Yonetici : MasrafYonetimiBase
    {
        public override void MasrafYonetimi(Masraf masraf)
        {
            if (masraf.Tutar<100 )
            {
                Console.WriteLine("bu masraf yönetici tarafindan yapilmiştir.");
            }
            else if(_sonraki!=null)
            {
                _sonraki.MasrafYonetimi(masraf);
            }
        }
    }
}
