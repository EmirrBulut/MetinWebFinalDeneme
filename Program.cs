using System;
using System.IO;
using System.Collections.Generic;

namespace MetinWebFinal
{
    class MainClass
    {
        
        
        public static List<string> ReadDatas()// Okunan verileri split etmeden once bunun icinde toplayacagız.
        {
            List<string> puredatas = new List<string>();
            string file_path = @"/Users/emirbulut/Desktop/Metin-WebFinal/MetinWebFinal/RestoranListesi.txt";
            FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string datas = sr.ReadLine();
            while (datas != null)
            {
                datas = sr.ReadLine();
                puredatas.Add(datas);
            }
            return puredatas;


        }

        public static List<RestoranAttiribute> SplitData(List<string> parameterdata)
        {
            List<RestoranAttiribute> restorans = new List<RestoranAttiribute>();
            for (int i = 0; i < 130; i++)
            {
                restorans.Add(new RestoranAttiribute());
            }

            string[] tempRestoransArray = parameterdata.ToArray();

            for (int i = 0; i < 130; i++)
            {
                restorans[i].Restoran_kodu = tempRestoransArray[i].Split(',')[0]; // Restoran kodu ozelligi atılıyor.
                if (tempRestoransArray[i].Split(',')[1] == "?") // Resotran Ortam puanı kontrol edılıyor 
                {
                    restorans[i].Ortam = Convert.ToInt16("0");
                }
                else
                {
                    restorans[i].Ortam = Convert.ToInt16(tempRestoransArray[i].Split(',')[1]);
                }
                if (tempRestoransArray[i].Split(',')[2] == "?")
                {
                    restorans[i].Ortam_temizligi = Convert.ToInt16("0");
                }
                else
                {
                    restorans[i].Ortam_temizligi = Convert.ToInt16(tempRestoransArray[i].Split(',')[2]);

                }
                if (tempRestoransArray[i].Split(',')[3] == "?")
                {
                    restorans[i].Yemek_kalitesi = Convert.ToInt16("0");
                }
                else
                {
                    restorans[i].Yemek_kalitesi = Convert.ToInt16(tempRestoransArray[i].Split(',')[3]);
                }
                if (tempRestoransArray[i].Split(',')[4] == "?")
                {
                    restorans[i].Hizmet_kalitesi = Convert.ToInt16("0");
                }
                else
                {
                    restorans[i].Hizmet_kalitesi = Convert.ToInt16(tempRestoransArray[i].Split(',')[4]);
                }
                if (tempRestoransArray[i].Split(',')[5]=="?")
                {
                    restorans[i].Fiyat_uygunlugu = Convert.ToInt16("0");
                }
                else
                {
                    restorans[i].Fiyat_uygunlugu = Convert.ToInt16(tempRestoransArray[i].Split(',')[5]);
                }
                if (tempRestoransArray[i].Split(',')[6] == "?")
                {
                    restorans[i].Ulasim_kolaylıgi = Convert.ToInt16("0");
                }
                else
                {
                    restorans[i].Ulasim_kolaylıgi = Convert.ToInt16(tempRestoransArray[i].Split(',')[6]);
                }
                if (tempRestoransArray[i].Split(',')[7] == "?")
                {
                    restorans[i].Araba_park_olanagi = Convert.ToInt16("0");
                }
                else
                {
                    restorans[i].Araba_park_olanagi = Convert.ToInt16(tempRestoransArray[i].Split(',')[7]);

                }
            }
            return restorans;
        }


        public static void Main(string[] args)
        {
            List<string> puredatas = ReadDatas(); // verileri okuttuk
            List<RestoranAttiribute> restorans2 = SplitData(puredatas); // her bir elemanı,bir restoranı ve onun ozellıklerının puanlarını tutan liste. Suan restorans2nin icinde 130 restoran nesnesi var.
            for (int i = 0; i < restorans2.Count; i++)
            {
                Console.WriteLine("Restoran Kodu : {0} - Ortam Temizligi : {1}",restorans2[i].Restoran_kodu,restorans2[i].Ortam_temizligi);
            }
            Console.WriteLine(restorans2.Count);
        }
    }
}
