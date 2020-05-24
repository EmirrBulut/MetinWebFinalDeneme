using System;
namespace MetinWebFinal
{
    public class RestoranAttiribute
    {
        public RestoranAttiribute()
        {
        }

        private string restoran_kodu;
        private int ortam;
        private int ortam_temizligi;
        private int yemek_kalitesi;
        private int hizmet_kalitesi;
        private int fiyat_uygunlugu;
        private int ulasim_kolaylıgi;
        private int araba_park_olanagi;

        public string Restoran_kodu { get => restoran_kodu; set => restoran_kodu = value; }
        public int Ortam { get => ortam; set => ortam = value; }
        public int Ortam_temizligi { get => ortam_temizligi; set => ortam_temizligi = value; }
        public int Yemek_kalitesi { get => yemek_kalitesi; set => yemek_kalitesi = value; }
        public int Hizmet_kalitesi { get => hizmet_kalitesi; set => hizmet_kalitesi = value; }
        public int Fiyat_uygunlugu { get => fiyat_uygunlugu; set => fiyat_uygunlugu = value; }
        public int Ulasim_kolaylıgi { get => ulasim_kolaylıgi; set => ulasim_kolaylıgi = value; }
        public int Araba_park_olanagi { get => araba_park_olanagi; set => araba_park_olanagi = value; }
    }
}
