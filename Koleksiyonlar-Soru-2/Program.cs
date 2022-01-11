using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Tumu = new ArrayList();
            ArrayList enBuyuk = new ArrayList();
            ArrayList enKucuk = new ArrayList();

            Console.WriteLine("Lütfen Sayı Giriniz");
            for (int i = 0; i < 20; i++)
            {
                Tumu.Add(int.Parse(Console.ReadLine()));
            }

            Tumu.Sort();
            int kucuk = 0;
            for (int i = 0; i < 3; i++)
            {
                enKucuk.Add(Tumu[i]);
                kucuk += Convert.ToInt32(Tumu[i]);
            }
            Tumu.Reverse();
            int buyuk = 0;
            for (int i = 0; i < 3; i++)
            {
                enBuyuk.Add(Tumu[i]);
                buyuk += Convert.ToInt32(Tumu[i]);

            }
            Console.WriteLine("En Büyük 3 Sayının Toplamı = " + buyuk + " Ortalaması = " + buyuk / enBuyuk.Count);
            Console.WriteLine("En Kü.ük 3 Sayının Toplamı = " + kucuk + " Ortalaması = " + kucuk / enKucuk.Count);


        }

    }
}
