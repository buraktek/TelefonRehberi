using System;
using System.Collections.Generic;

namespace TelefonRehberi
{
    class Program
    {

        static void Main(string[] args)
        {
            Metods metod = new Metods();
            VeriEkle();

            Console.WriteLine("Telefon Rehberinize Hoşgeldiniz...");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
            Console.WriteLine("**********************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek "); //
            Console.WriteLine("(2) Varolan Numarayı Silmek "); //
            Console.WriteLine("(3) Varolan Numarayı Güncelleme ");
            Console.WriteLine("(4) Rehberi Listelemek ");
            Console.WriteLine("(5) Rehberde Arama Yapmak ");
            Console.WriteLine("(X) Çıkış ");
            Console.WriteLine("**********************************************");

            while (true)
            {
                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        metod.NumaraKaydet(); 
                        break;
                    case "2":
                        metod.NumaraSilme();  
                        break;
                    case "3":
                        metod.NumaraGuncelleme(); 
                        break;
                    case "4":
                        metod.RehberListeleme();
                        break;
                    case "5":
                        metod.AramaYapma();
                        break;
                    case "X":
                    case "x":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }



            void VeriEkle()
            {

                Kisiler kisi1 = new Kisiler("Abdurrahim Burak", "Tekin", "05312345678");
                Kisiler kisi2 = new Kisiler("Ahmet", "Hür", "05312345679");
                Kisiler kisi3 = new Kisiler("Mehmet", "Tek", "05312345677");
                Kisiler kisi4 = new Kisiler("Fatma Nur", "Çetin", "05312345676");
                Kisiler kisi5 = new Kisiler("Halime", "Acar", "05312345675");
                metod.KisiEkle(kisi1);
                metod.KisiEkle(kisi2);
                metod.KisiEkle(kisi3);
                metod.KisiEkle(kisi4);
                metod.KisiEkle(kisi5);
            }
        }





    }


}
