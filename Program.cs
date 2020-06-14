using System;
using System.IO;
using System.Collections.Generic;

namespace MetinWebFinal
{
    class MainClass
    {
        
        
        public static List<string> ReadDatas()// Okunan verileri split etmeden once bunun icinde toplayacagız.
        {
            try
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
            catch (Exception)
            {
                throw new Exception("Train Set Okunamiyor. Lutfen Tekrar Deneyin");
            }


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
                    restorans[i].Ortam = Convert.ToInt16("-1");
                }
                else
                {
                    restorans[i].Ortam = Convert.ToInt16(tempRestoransArray[i].Split(',')[1]);
                }
                if (tempRestoransArray[i].Split(',')[2] == "?")
                {
                    restorans[i].Ortam_temizligi = Convert.ToInt16("-1");
                }
                else
                {
                    restorans[i].Ortam_temizligi = Convert.ToInt16(tempRestoransArray[i].Split(',')[2]);

                }
                if (tempRestoransArray[i].Split(',')[3] == "?")
                {
                    restorans[i].Yemek_kalitesi = Convert.ToInt16("-1");
                }
                else
                {
                    restorans[i].Yemek_kalitesi = Convert.ToInt16(tempRestoransArray[i].Split(',')[3]);
                }
                if (tempRestoransArray[i].Split(',')[4] == "?")
                {
                    restorans[i].Hizmet_kalitesi = Convert.ToInt16("-1");
                }
                else
                {
                    restorans[i].Hizmet_kalitesi = Convert.ToInt16(tempRestoransArray[i].Split(',')[4]);
                }
                if (tempRestoransArray[i].Split(',')[5]=="?")
                {
                    restorans[i].Fiyat_uygunlugu = Convert.ToInt16("-1");
                }
                else
                {
                    restorans[i].Fiyat_uygunlugu = Convert.ToInt16(tempRestoransArray[i].Split(',')[5]);
                }
                if (tempRestoransArray[i].Split(',')[6] == "?")
                {
                    restorans[i].Ulasim_kolaylıgi = Convert.ToInt16("-1");
                }
                else
                {
                    restorans[i].Ulasim_kolaylıgi = Convert.ToInt16(tempRestoransArray[i].Split(',')[6]);
                }
                if (tempRestoransArray[i].Split(',')[7] == "?")
                {
                    restorans[i].Araba_park_olanagi = Convert.ToInt16("-1");
                }
                else
                {
                    restorans[i].Araba_park_olanagi = Convert.ToInt16(tempRestoransArray[i].Split(',')[7]);

                }
            }
         
            return restorans;
        }

        public static RestoranAttiribute ConsoleOperations()
        {
            int input = 0;
            string[] kriterler = { "Ortam", "Ortam Temizligi", "Yemek Kalitesi", "Hizmet Kalitesi", "Fiyat Uygunlugu", "Uasım Kolayligi", "Araba Park Olanagi" };
            Console.WriteLine("----------Restoran Oneri Sistemine Hosgeldiniz----------");
            Console.WriteLine("Simdi Sirasyla Size Uygun Kriter Puanlarini Gireceksiniz");

            RestoranAttiribute restoranAttiribute = new RestoranAttiribute();
           
            try
            {
               
                Console.WriteLine("{0}) {1} kriterinin sizin icin onemini 0 - 10 arasinda puanlayin",1, kriterler[0]);
                input = Convert.ToInt16(Console.ReadLine());
                if (input >= 0 && input <= 10)
                {
                    restoranAttiribute.Ortam = input;

                }
                else
                {
                    throw new Exception();
                }
                Console.WriteLine("{0}) {1} kriterinin sizin icin onemini 0 - 10 arasinda puanlayin",2, kriterler[1]);
                input = Convert.ToInt16(Console.ReadLine());
                if (input >= 0 && input <= 10)
                {
                    restoranAttiribute.Ortam_temizligi = input;

                }
                else
                {
                    throw new Exception();
                }
                Console.WriteLine("{0}) {1} kriterinin sizin icin onemini 0 - 10 arasinda puanlayin", 3, kriterler[2]);
                input = Convert.ToInt16(Console.ReadLine());
                if (input >= 0 && input <= 10)
                {
                    restoranAttiribute.Yemek_kalitesi = input;
                }
                else
                {
                    throw new Exception();
                }
                Console.WriteLine("{0}) {1} kriterinin sizin icin onemini 0 - 10 arasinda puanlayin", 4, kriterler[3]);
                input = Convert.ToInt16(Console.ReadLine());
                if (input >= 0 && input <= 10)
                {
                    restoranAttiribute.Hizmet_kalitesi = input;

                }
                else
                {
                    throw new Exception();
                }
                Console.WriteLine("{0}) {1} kriterinin sizin icin onemini 0 - 10 arasinda puanlayin", 5, kriterler[4]);
                input = Convert.ToInt16(Console.ReadLine());
                if (input >= 0 && input <= 10)
                {
                    restoranAttiribute.Fiyat_uygunlugu = input;

                }
                else
                {
                    throw new Exception();
                }
                Console.WriteLine("{0}) {1} kriterinin sizin icin onemini 0 - 10 arasinda puanlayin", 6, kriterler[5]);
                input = Convert.ToInt16(Console.ReadLine());
                if (input >= 0 && input <= 10)
                {
                    restoranAttiribute.Ulasim_kolaylıgi = input;

                }
                else
                {
                    throw new Exception();
                }
                Console.WriteLine("{0}) {1} kriterinin sizin icin onemini 0 - 10 arasinda puanlayin", 7, kriterler[6]);
                input = Convert.ToInt16(Console.ReadLine());
                if (input >= 0 && input <= 10)
                {
                    restoranAttiribute.Araba_park_olanagi = input;

                }
                else
                {
                    throw new Exception();
                }


            }
            catch (Exception)
            {
                Console.WriteLine("Hatali giris yaptiniz !! Lutfen 0-10 arasi sayisal bir deger girerek tekrar bastan baslayin.");
            }
      
            return restoranAttiribute;
        }

        public static double[] CosinusSimilarity(List<RestoranAttiribute> restorans, RestoranAttiribute restoranAttiribute)
        {
            double[] similarityarray = new double[130] ; // En son hesaplanan benzerlik değerlerini barındıracak array.
            double[] productsofAiBi = new double[130]; // PAY
            double[] squaresproduct = new double[130]; // PAYDA

            double sumofpay = 0;
            double squareofAi = 0, squareofBi = 0;
            int counter = 0;
            while (counter < restorans.Count)
            {
                if (restorans[counter].Ortam != -1)
                {
                    sumofpay += restorans[counter].Ortam * restoranAttiribute.Ortam;
                    squareofAi += restorans[counter].Ortam * restorans[counter].Ortam;
                    squareofBi += restoranAttiribute.Ortam * restoranAttiribute.Ortam;
                }
                if (restorans[counter].Ortam_temizligi != -1)
                {
                    sumofpay += restorans[counter].Ortam_temizligi * restoranAttiribute.Ortam_temizligi;
                    squareofAi += restorans[counter].Ortam_temizligi * restorans[counter].Ortam_temizligi;
                    squareofBi += restoranAttiribute.Ortam_temizligi * restoranAttiribute.Ortam_temizligi;
                }
                if (restorans[counter].Yemek_kalitesi != -1)
                {
                    sumofpay += restorans[counter].Yemek_kalitesi * restoranAttiribute.Yemek_kalitesi;
                    squareofAi += restorans[counter].Yemek_kalitesi * restorans[counter].Yemek_kalitesi;
                    squareofBi += restoranAttiribute.Yemek_kalitesi * restoranAttiribute.Yemek_kalitesi;
                }
                if (restorans[counter].Hizmet_kalitesi != -1)
                {
                    sumofpay += restorans[counter].Hizmet_kalitesi * restoranAttiribute.Hizmet_kalitesi;
                    squareofAi += restorans[counter].Hizmet_kalitesi * restorans[counter].Hizmet_kalitesi;
                    squareofBi += restoranAttiribute.Hizmet_kalitesi * restoranAttiribute.Hizmet_kalitesi;
                }
                if (restorans[counter].Fiyat_uygunlugu != -1)
                {
                    sumofpay += restorans[counter].Fiyat_uygunlugu * restoranAttiribute.Fiyat_uygunlugu;
                    squareofAi += restorans[counter].Fiyat_uygunlugu * restorans[counter].Fiyat_uygunlugu;
                    squareofBi += restoranAttiribute.Fiyat_uygunlugu * restoranAttiribute.Fiyat_uygunlugu;
                }
                if (restorans[counter].Ulasim_kolaylıgi != -1)
                {
                    sumofpay += restorans[counter].Ulasim_kolaylıgi * restoranAttiribute.Ulasim_kolaylıgi;
                    squareofAi += restorans[counter].Ulasim_kolaylıgi * restorans[counter].Ulasim_kolaylıgi;
                    squareofBi += restoranAttiribute.Ulasim_kolaylıgi * restoranAttiribute.Ulasim_kolaylıgi;
                }
                if (restorans[counter].Araba_park_olanagi != -1)
                {
                    sumofpay += restorans[counter].Araba_park_olanagi * restoranAttiribute.Araba_park_olanagi;
                    squareofAi += restorans[counter].Araba_park_olanagi * restorans[counter].Araba_park_olanagi;
                    squareofBi += restoranAttiribute.Araba_park_olanagi * restoranAttiribute.Araba_park_olanagi;
                }
                productsofAiBi[counter] = sumofpay; // Counterıncı restoranın pay degeri
                squaresproduct[counter] = Math.Sqrt(squareofAi) * Math.Sqrt(squareofBi);
                counter++;
                sumofpay = 0;
                squareofAi = 0;
                squareofBi = 0;
            }
            for (int i = 0; i < restorans.Count; i++)
            {
                similarityarray[i] = productsofAiBi[i] / squaresproduct[i];
            }
            return similarityarray;
        }

        public static bool LastOperation(List<RestoranAttiribute> purerestorans,double[] distances,int k)
        {
            Dictionary<string, double> view = new Dictionary<string, double>();
            int counter = 0;
            int index = 0;
            while (counter < k )
            {
                double max = distances[0];
                            
                for (int i = 1; i < distances.Length; i++)
                {
                    if (distances[i] > max)
                    {
                        max = distances[i];
                        index = i;
                    }
                }
                view.Add(purerestorans[index].Restoran_kodu, max);
                distances[index] = -1;
                counter++;
            }
            double tempvalue = 0; // bu asagıdaki listelere kadar olan kısım 3 isteyip 5 yazdırmak gerektigi kısımla ılgılı ama emın degılım.
            foreach (var item in view.Values)
            {
                tempvalue = item;
            }
            for (int i = index + 1; i < distances.Length; i++)
            {
                if (distances[i] == tempvalue)
                {
                    view.Add(purerestorans[i].Restoran_kodu, distances[i]);
                }
            }

            List<string> restorannumber = new List<string>();
            List<double> restorandistance = new List<double>();

            foreach (var item in view.Keys)
            {
                restorannumber.Add(item);
            }
            foreach (var item in view.Values)
            {
                restorandistance.Add(item);
            }

            for (int i = 0; i < restorannumber.Count; i++)
            {
                Console.WriteLine("{0}. Oneri --> Restoran Numarasi : {1} - Benzerlik Derecesi : {2}", i + 1, restorannumber[i], restorandistance[i]);
            }

            Console.WriteLine("Tekrar denemek icin '1', cikmak icin '0' tuslayiniz.");
            string input = Console.ReadLine();
            if (input == "1")
            {
                return true;
            }
            else if (input == "0")
            {
                Console.WriteLine("Iyi Gunler :)");
            }
            else
            {
                Console.WriteLine("Hatali giris yaptiniz bastan baslayin.");
            }
            
      

            return false;

        }

        public static int GetK()
        {
            int k = 0;
            try
            {
                Console.WriteLine("Lutfen kac restoran onerilmesini istediginizi girin. Girdiginiz sayi 1-15 arasinda olmali!!");
                k = Convert.ToInt16(Console.ReadLine());
                if (k >= 1 && k <= 15)
                {
                    Console.WriteLine("Hesaplaniyor....");
                }
                else
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Hatali giris yaptiniz lutfen tekrar deneyin");
                throw new Exception();
            }
            return k;
        }
        public static void Main(string[] args)
        {
            List<string> puredatas = ReadDatas(); // verileri okuttuk
            List<RestoranAttiribute> restorans2 = SplitData(puredatas); // her bir elemanı,bir restoranı ve onun ozellıklerının puanlarını tutan liste. Suan restorans2nin icinde 130 restoran nesnesi var
            RestoranAttiribute restoranAttiribute2 =  ConsoleOperations();
            double[] distances = CosinusSimilarity(restorans2, restoranAttiribute2);
            int k = GetK();
            bool isOkey = LastOperation(restorans2, distances, k);
            while (isOkey == true)
            {
                List<string> puredatas2 = ReadDatas(); // verileri okuttuk
                List<RestoranAttiribute> restorans3 = SplitData(puredatas2); // her bir elemanı,bir restoranı ve onun ozellıklerının puanlarını tutan liste. Suan restorans2nin icinde 130 restoran nesnesi var
                RestoranAttiribute restoranAttiribute3 =  ConsoleOperations();
                double[] distances2 = CosinusSimilarity(restorans3, restoranAttiribute3);
                int k2 = GetK();
                bool isOkey2 = LastOperation(restorans3, distances2, k2);
            }
            // sadece su yanlıs gırdıgınde devam etme sorununu cozmek kaldı

        }
    }
}
