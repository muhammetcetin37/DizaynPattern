using ChainOffResponsibility.Abstract;
using ChainOffResponsibility.Concrete;
using ChainOffResponsibility.Lab2.Concrete;
using ChainOffResponsibility.Lab2.Model;
using System;
using System.Collections.Generic;

namespace ChainOffResponsibilty
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region lab1
            ////zincirin halkalarını baglayalım
            //PlayerHandler mp3 = new Mp3Player();
            //PlayerHandler mp4 = new Mp4Player();
            //PlayerHandler avi = new AviPlayer();

            ////bu halkalari birbirinr baglayalim

            //mp3.NextHandler = avi;
            //avi.NextHandler = mp4;

            ////istekleri zincirin ilk halkasına gönderelim
            //mp3.Player("video.avi");
            //mp3.Player("video.mp3");
            //mp3.Player("video.mp4");
            //mp3.Player("video.xxx");

            #endregion
            #region lab2
            Yonetici yonetici = new Yonetici();
            GenelMudur genelMudur = new GenelMudur();
            CEO ceo = new CEO();
            yonetici.MasrafMerkezi(genelMudur);
            genelMudur.MasrafMerkezi(ceo);
            List<Masraf> masraflar = new List<Masraf>
            {
                new Masraf{ Tutar=70},
                new Masraf{ Tutar=250},
                new Masraf{ Tutar=4999},
                new Masraf{ Tutar=50070},
            };

            foreach (Masraf masraf in masraflar)
            {
                yonetici.MasrafYonetimi(masraf);
            }
            #endregion


            Console.WriteLine("Hello World!");
        }
    }
}
