using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = { 28, -11, 99, 33, 45};
            int enKucuksayı = sayiDizisi[0]; 
            int enBuyuksayı = sayiDizisi[0]; 
            double Toplam = 0;

            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                if (enBuyuksayı < sayiDizisi[i])
                {
                    enBuyuksayı = sayiDizisi[i];
                }
                if (enKucuksayı > sayiDizisi[i]) 
                {
                    enKucuksayı = sayiDizisi[i];
                }
                Toplam += sayiDizisi[i]; 
            }
            Console.WriteLine("Dizinin en büyük sayısı = " + enBuyuksayı);
            Console.WriteLine("Dizinin en küçük sayısı = " + enKucuksayı);
            Console.WriteLine("Dizideki sayıların ortalaması = " + Toplam / (sayiDizisi.Length)); 
            Console.ReadLine();

        }
    }
}
