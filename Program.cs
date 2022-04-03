using System;
using System.Collections;


namespace koleksiyonlar_soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
            //her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama 
            //toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            int[] dizi = new int[20];

            Console.WriteLine("Lütfen 20 adet sayı giriniz.:");
            for (int i = 0; i < 20; i++)
            {
                dizi[i] =int.Parse(Console.ReadLine());

            }

            Console.WriteLine("***sıralama****");
            Array.Sort(dizi);
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("****enküçük***");

            ArrayList enkucukSayilar = new ArrayList();
            enkucukSayilar.Add(dizi[0]);
            enkucukSayilar.Add(dizi[1]);
            enkucukSayilar.Add(dizi[2]);

            foreach (var item in enkucukSayilar)
               Console.WriteLine(item);

            int toplam;
            int ortalama;


            toplam= dizi[0]+dizi[1]+dizi[2];
            ortalama =toplam/3;
            Console.WriteLine("****küçük ortalama****");
            Console.WriteLine(ortalama);

            Console.WriteLine("****enbüyük***");
            ArrayList enbuyuksayilar = new ArrayList();
            enbuyuksayilar.Add(dizi[19]);
            enbuyuksayilar.Add(dizi[18]);
            enbuyuksayilar.Add(dizi[17]);

             foreach (var item in enbuyuksayilar)
               Console.WriteLine(item);
            
            int toplam2;
            int ortalama2;
            
            toplam2 = dizi[19]+dizi[18]+dizi[17];
            ortalama2 = toplam2/3;
            Console.WriteLine("****büyük ortalama****");
            Console.WriteLine(ortalama2);
            
            Console.WriteLine("****toplam ortalama****");
            Console.WriteLine(ortalama+ortalama2);
            

            
            





           







        }
    }
}

