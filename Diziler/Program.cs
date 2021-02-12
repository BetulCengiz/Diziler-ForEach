using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizilerde tanımlama köşeli parantez
            // Index: 0'dan başlar 

            //int[] sayilar = { 10, 45, 21, 34, 54, };
            //string[] isimler = {"bety","bedi"};                   
            //Console.WriteLine(isimler[0]);

            // Dizi oluşturma yöntem iki-klavyeden girdi alınacaksa

            //string[] sehirler = new string[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Şehir: ");
            //    sehirler[i] = Console.ReadLine();
            //}
            //Console.WriteLine("***********");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}

            //int[] sayilar = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write((i+1).ToString() +". sayıyı giriniz" );
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine()); // convert ettik çünkü üstünlük karşılaştırıyor

            //}
            //int enbuyuk;
            //enbuyuk = sayilar[0];

            //for (int i = 1; i < 5; i++)
            //{
            //    if (enbuyuk<sayilar[i])
            //    {
            //        enbuyuk = sayilar[i];
            //    }
            //}
            //Console.WriteLine("En büyük sayı:" + enbuyuk);

            //2-örenci ad soyad 3 sınav girişi ve dizi değeri dolunca listeleme



            //    string[] isim_soyisim = new string[3];
            //    int[] s1 = new int[3];
            //    int[] s2 = new int[3];
            //    int[] ort = new int[3];

            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.Clear();

            //        Console.WriteLine(i+1 + " Öğrencinin Adı: ");
            //        isim_soyisim[i] = Console.ReadLine();

            //        Console.WriteLine(i + 1 + " Sınav 1: ");
            //        s1[i] = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine(i + 1 + " Sınav 2: ");
            //        s2[i] = Convert.ToInt32(Console.ReadLine());

            //        ort[i] = (s1[i] + s2[i]) / 2;
            //    }
            //    Console.Write(" Öğrenci-Sınav1-Sınav2-Ortalama");
            //    Console.WriteLine();
            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.WriteLine("  "+ isim_soyisim[i]+ "   " + s1[i]+"   "+ s2[i]+"   "+ort[i]);
            //    }


            //3-for-each döngüsü bir dizinin tüm elemanlarına ulamak için kullanılır
            // python da for i in range mantığı
            //foreach (değişken türü- değişken adı- in-dizi adı){ }


            //string[] sehirler = { "Mersin", "İzmir", "Urfa", "Adana", "Bursa" };

            //foreach (string i in sehirler)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] sayilar = {1,10,43,57,32 };

            //foreach (int item in sayilar)
            //{
            //    if (item % 2==0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //4-
            //bir dizi oluştur sayılar ekle pozitif ve tek sayıları listele

            //int[] sayilar = { 4,1,7, -8, 23, 14, 51, 84, -75,26,-8,9 };

            //foreach (int i in sayilar)
            //{
            //    if (i >0 && i%2!=0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //hazır komutlar

            //int[] dizi = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("sayıyı girin: ");
            //    dizi[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Array.Sort(dizi); //sort>> sayıları sıralar 

            //foreach (int item in dizi)
            //{
            //    Console.WriteLine(item);
            //}

            //tersten sıralama

            int[] dizi = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("sayıyı girin: ");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Reverse(dizi); //reverse>> sayıları ters sıralar(giriş sırasının tersine)
            foreach (int item in dizi)
            {
                Console.WriteLine(item);
            }


        }


    }
}
