using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Cümle Giriniz");
            string cumle = Console.ReadLine();
            ArrayList harf = new ArrayList();
            string sesliharf = "aeıioöuüAEIİOÖUÜ";
            
            for (int i = 0; i < cumle.Length; i++)
            {
                if(sesliharf.Contains(cumle[i]))
                {
                    
                    harf.Add(cumle[i]);
                }
            }

            foreach (var item in harf)
            {
                Console.WriteLine(item);
            }


        }
    }
}
