using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Musteri> musteriler = new List<Musteri>();
            Musteri m1 = new Musteri() { id = 1, Ad = "Fatih", Soyad = "BAYTAR", TcKimlik = "43424234", Kategori = new Kategori() { id = 1, KategoriAdi = "Bireysel" }, Telefon = new Telefon() { id = 1, TelefonNo = "5424666388", TelefonTipi = "Cep" }, Adres = new Adres() { id = 1, Adresi = "SmartPro Bilişim Akademisi", AdresTipi = "İş" } };
            Musteri m2 = new Musteri() { id = 2, Ad = "Mehmet", Soyad = "BAYTAR", TcKimlik = "55892980", Kategori = new Kategori() { id = 2, KategoriAdi = "Kurumsal" }, Telefon = new Telefon() { id = 1, TelefonNo = "231324123", TelefonTipi = "Ev" }, Adres = new Adres() { id = 2, Adresi = "Dörtyol", AdresTipi = "Ev" } };
            Musteri m3 = new Musteri() { id = 3, Ad = "Arif", Soyad = "Akkoyun", TcKimlik = "009238489234", Kategori = new Kategori() { id = 1, KategoriAdi = "Bireysel" }, Telefon = new Telefon() { id = 3, TelefonNo = "867576567", TelefonTipi = "Cep" }, Adres = new Adres() { id = 3, Adresi = "Dörtyol", AdresTipi = "İş" } };
            Musteri m4 = new Musteri() { id = 4, Ad = "Aydın", Soyad = "ARIKAN", TcKimlik = "2345234", Kategori = new Kategori() { id = 2, KategoriAdi = "Kurumsal" }, Telefon = new Telefon() { id = 2, TelefonNo = "532345234", TelefonTipi = "Cep" }, Adres = new Adres() { id = 4, Adresi = "Dörtyol", AdresTipi = "İş" } };
            Musteri m5 = new Musteri() { id = 1, Ad = "Kenan", Soyad = "ÜNAL", TcKimlik = "23452345", Kategori = new Kategori() { id = 1, KategoriAdi = "Bireysel" }, Telefon = new Telefon() { id = 5, TelefonNo = "52345234", TelefonTipi = "Cep" }, Adres = new Adres() { id = 5, Adresi = "İskenderun", AdresTipi = "İş" } };
            Musteri m6 = new Musteri() { id = 1, Ad = "Rıza", Soyad = "YÖNAÇ", TcKimlik = "5234234", Kategori = new Kategori() { id = 2, KategoriAdi = "Kurumsal" }, Telefon = new Telefon() { id = 6, TelefonNo = "0982351", TelefonTipi = "Cep" }, Adres = new Adres() { id = 3, Adresi = "Mersin", AdresTipi = "İş" } };
            musteriler.AddRange(new List<Musteri>() {m1,m2,m3,m4,m5,m6 });

            //Tüm müşterilerin adları dönülüyor
            //foreach (Musteri item in musteriler)
            //{
            //    Console.WriteLine(item.Ad+" "+item.Soyad);
            //}
            var donguDevamEttirici = true;
            do
            {
                Console.WriteLine("Arama yapılacak özellik için aşağıdaki listeden bir sayı seçin:");
                Console.WriteLine("1: Ad\n2:Soyad\n3:Telefon\n4:Kategori\nq:Çıkış");
                var secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Lütfen Müşterinin adında aramak istediğiniz harfi veya harfleri girin");
                        var aranacak = Console.ReadLine();
                        var sonuc = from m in musteriler
                                    where m.Ad.ToUpper().Contains(aranacak.ToUpper())
                                    select m;
                        if(sonuc.Count()==0)
                        {
                            Console.WriteLine("Hiçbir sonuç bulunamadı");
                            break;
                        }
                        foreach (Musteri mus in sonuc)
                        {
                            Console.WriteLine("Bulunan müşterinin Adı :{0}",mus.Ad);
                        }
                        

                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "q":
                        donguDevamEttirici = false;
                        break;
                    default:
                        Console.WriteLine("Lütfen belirtilen sayılardan birini veya q harfini tuşlayın");
                        continue;
                        
                }


            } while (donguDevamEttirici);

        }
    }
}
