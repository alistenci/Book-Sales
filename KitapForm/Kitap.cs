using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapForm
{
    public class Kitap
    {
        public string Kategori;
        public string kitapAdi;
        public string yazari;
        public string yayinevi;
        public int sayfaSayisi;
        public int fiyat;

        public Kitap(string kategori, string kitapAdi, string yazari, string yayinevi, int sayfaSayisi, int fiyat)
        {
            Kategori = kategori;
            this.kitapAdi = kitapAdi;
            this.yazari = yazari;
            this.yayinevi = yayinevi;
            this.sayfaSayisi = sayfaSayisi;
            this.fiyat = fiyat;
        }
    }
}
