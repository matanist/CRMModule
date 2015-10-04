using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMModule
{
    public class Musteri
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcKimlik { get; set; }
        public Kategori Kategori { get; set; }
        public Telefon Telefon { get; set; }
        public Adres Adres { get; set; }
    }
    public class Kategori
    {
        public int id { get; set; }
        public string KategoriAdi { get; set; }
    }
    public class Telefon
    {
        public int id { get; set; }
        public string TelefonNo { get; set; }
        public string TelefonTipi { get; set; }
    }
   public class Adres
    {
        public int id { get; set; }
        public string Adresi { get; set; }
        public string AdresTipi { get; set; }
    }

}
