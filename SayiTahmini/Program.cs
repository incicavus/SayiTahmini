using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahmini
{
    class Program
    {
        static void Main(string[] args)
        {

            Random gen = new Random();

            int sayi1 = gen.Next(); // negatif olmayan bir int sayı (max int değerine kadar) oluşturur.
            int sayi2 = gen.Next(100); // [0,99] sayı aralığında (100hariç) negatif olmayan bir int sayı oluşturur.
            int sayi3 = gen.Next(250, 301); // [250,301) sayı aralığında (250 dahil, 301 hariç) bir int sayı oluşturur.

            double noktali = gen.NextDouble(); //0.0 ile 1.0 arasında noktalı sayı üretir.

            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            Console.WriteLine(sayi3);
            Console.WriteLine(noktali);

            Console.Clear(); // console ekrarnını temizle.

            // pc bir sayı üretir ve biz o sayıyı buluncaya kadar daha büyük veya daha küçük sayı girmemiz yönünde yönergeler gösterecek kodları yazalım. (101e kadar olan sayılar)

            Random rastgele = new Random();
            string istek=" ";
            do
            {
                Console.Clear(); // önceki bilgileri sil
            int rst = rastgele.Next(101);
            //Console.WriteLine(rst);
            Console.Write("Tahmininiz nedir: ");
            int girilenSayi = Convert.ToInt32(Console.ReadLine());
            int deneme = 1;

            while (girilenSayi!=rst)
            {
                deneme++;
                if (girilenSayi>rst)
                {
                     Console.Write("Daha küçük bir sayı giriniz ");
                    girilenSayi = Convert.ToInt32(Console.ReadLine());
                }
            
             
            else if (girilenSayi<rst)
	{
        Console.Write("Daha büyük bir sayı giriniz ");
        girilenSayi = Convert.ToInt32(Console.ReadLine());
	}
            }

            Console.WriteLine("Tebrikler, {1} denemede doğruyu buldunuz. Sayı {0} olarak üretilmişti..",rst,deneme);        
                Console.Write("Yeniden oynamak ister misiniz? (e/h) : ");
                istek=Console.ReadLine();

            } while (istek.ToLower()=="e"); // .ToLower büyük harfte küçük harfte girse algılar.
            //Console.ReadLine();

            
        }
    }
}
