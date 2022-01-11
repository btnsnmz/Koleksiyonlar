using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList AsalOlan = new ArrayList();
            ArrayList AsalOlmayan = new ArrayList();
            Console.WriteLine("Lütfen Sayı Giriniz");
            for (int i = 0; i < 20; i++)
            {
                int gelen = int.Parse(Console.ReadLine());
                if (NegatifKontrol(gelen))
                {
                    int say = 0;
                    for (int j = 2; j < gelen; j++)
                    {
                        if (gelen % j == 0)
                        {
                            say++;
                        }


                    }
                    if (say == 0)
                    {
                        if (say == 1)
                        {
                            AsalOlmayan.Add(gelen);
                        }
                        else
                            AsalOlan.Add(gelen);
                    }
                    else
                        AsalOlmayan.Add(gelen);

                }
                else
                    Console.WriteLine("Lütfen Sayi Giriniz");
            }
            AsalOlan.Sort();
            AsalOlan.Reverse();
            AsalOlmayan.Sort();
            AsalOlmayan.Reverse();

            Console.WriteLine("-----Asal Olan Sayılar-----");
            foreach (var item in AsalOlan)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----Asal Olmayan Sayılar-----");
            foreach (var item in AsalOlmayan)
            {
                Console.WriteLine(item);
            }
            int toplam1=0;
            int toplam2=0;
            foreach (var item in AsalOlmayan)
            {
                toplam1+=Convert.ToInt32(item);
            }
             foreach (var item in AsalOlan)
            {
                toplam2+=Convert.ToInt32(item);
            }
            Console.WriteLine("Asal Olmayan eleman sayısı = "+AsalOlmayan.Count+ "Ortalaması = "+toplam1/AsalOlmayan.Count);
              Console.WriteLine("Asal Olan eleman sayısıı = "+AsalOlan.Count+ "Ortalaması = "+toplam2/AsalOlan.Count);


        }
        static bool NegatifKontrol(int deger)
        {
            bool sonuc = false;
            if (deger > 0)
            {
                sonuc = true;
            }
            return sonuc;
        }
    }

}
