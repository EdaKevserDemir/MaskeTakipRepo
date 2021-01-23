using Business.Concrete;
using System;
using System.Collections.Generic;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            // Degiskenler();

            Vatandas vatandas1 = new Vatandas(); //intance oluşturduk.

            SelamVer("eda");
            SelamVer("mehmet");
            SelamVer();

            int sonuc = Topla(50);

            //Arrays

            string ogr1 = "eda";
            string ogr2 = "kevser";
            string ogr3 = "demir";


            string[] ogrenciler = new string[3];
            ogrenciler[0] = "eda";
            ogrenciler[1] = "kevser";
            ogrenciler[2] = "demir";

            ogrenciler = new string[4];
            ogrenciler[3] = "meryem";


            string[] sehirler1 = new[] { "ankara", "istanbul", "izmir" };
            string[] sehirler2 = new[] { "bursa", "antalya", "diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "adana";
            Console.WriteLine(sehirler2[0]);




            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            foreach(string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

             
            List<string> yeniSehirler1 = new List<string> { "ankara", "istanbul", "izmir" };
            yeniSehirler1.Add("adana");
            foreach(var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }


            PttManager pttManager = new PttManager(new ForeignerManager);
            pttManager.GiveMask(per);



            Console.ReadLine();
        }

        static void SelamVer(string isim = "noname")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + sonuc);
            return sonuc;
        }



        private static void Degiskenler()
        {
            string mesaj = "Selam";
            double tutar = 10000.18;
            int sayi = 100;
            bool girisYapmismi = false;

            string Adi = "Eda";
            string Soyadi = "Demir";
            int dogumYili = 1993;
            long TcNo = 12365478963;


            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(mesaj);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Dogumyili { get; set; }
        public long TcNo { get; set; }


    }



}
