using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace W12_Exception_Filtering
{
    class Program
    {

        static void Main(string[] args)
        {
            /// 1. SORU
            /// 
            /*
            string[] depts = { "MIS", "History", "Physics", "Economics" };
            object[] departments = depts;
            try
            {
                
                departments[1] = 9.8;

            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }
            */


            /// soru 2
            /// 
            /*
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            */
            /// soru 3
            /*
            try
            {
                using (var reader = new StreamReader("test.txt"))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
                Console.ReadLine();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            */

            /// soru 4
            /*
            string[] places = { "ankara", "maskara", "karagöz", "karaburun" };

            for (int i = 0; i < places.Length; i++)
            {
                if (places[i].StartsWith("kara"))
                {
                    places[i] = places[i].Replace("kara", "beyaz");
                }
            }

            foreach (string place in places)
            {
                Console.WriteLine(place);
            }
            */

            /* 5. soru ilk kısım

       public static  void lastindex(int[] dizim)
       {

           for (int i = 0; i < dizim.Length; i++)
           {
               if (i == dizim.Length - 1)
               {
                   Console.WriteLine(dizim[i]);
               }
           }

       }
           int[] dizim = { 2, 234, 234, 254, 345, 3, 53 };
           lastindex(dizim);
           */
            /// 5. soru 2. kısım

            /*
            static string CustomSubstring(string input, int startIndex, int length)
            {
                string result = "";
                for (int i = 0; i < length; i++)
                {
                    result += input[startIndex + i];
                }
                return result;
            }

            string stringim = ("FURKANBABA9");
           Console.WriteLine( CustomSubstring(stringim , 3, 6));
            
            */

            /// 6. soru
            /*
            string tarih1 = ("Oct 23, 1923");
            string tarih2 = ("Mar 18 , 1915");

            DateTime ilktarih = DateTime.Parse(tarih1);
            DateTime ikincitarih = DateTime.Parse(tarih2);

            TimeSpan tarihlerarasıfark = ilktarih - ikincitarih;

            Console.WriteLine(tarihlerarasıfark.Days);
            */

            /// 7. soru
            /// 
            /*
            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("z: ");
            double z = double.Parse(Console.ReadLine());

            
            double a = x + y + z; // a, toplam uzunluk
            double b = y + z;     // b, iki kenarın toplamı
            double c = x + z;     // c, iki kenarın toplamı

            
            double area = 0.5 * (Math.Pow(b, 2) * Math.Acos(b / a) +
                                 Math.Pow(c, 2) * Math.Acos(c / a) -
                                 b * c);
            Console.WriteLine($"Kesişim alanı: {area}");
        
            */
            /// 8. soru
            /*
             static double harmonicçevir(int a , int b , int c , int d , int e)
             {


                 double harmonicçözüm =( 5.0 / (1.0/a + 1.0/b + 1.0/c + 1.0/d + 1.0/e));

                 return harmonicçözüm;

             }
             int a;
             int b;
             int c;
             int d;
             int e;
             Console.WriteLine("Lütfen 5 tane değer giriniz");
             a = Convert.ToInt32(Console.ReadLine());
             b = Convert.ToInt32(Console.ReadLine());
             c = Convert.ToInt32(Console.ReadLine());
             d = Convert.ToInt32(Console.ReadLine());
             e = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine ( harmonicçevir(a , b , c , d , e));

             */

            /// 9. soru
            /*
            static void alyazdır (List<string> list)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Lütfen bir string giriniz giriniz: ");
                    string yazım =  Console.ReadLine();
                    list.Add(yazım);
                    list.Sort();
                }
                foreach (string i in  list) { 
                Console.WriteLine(i);}

                
            }

            List<string> list = new List<string>();
            alyazdır(list);
            *
            */
            /// 10. soru
            ///
            /*
            static void PrintNumbers(int intNumber, double doubleNumber)
            {
                // Eğer herhangi bir sayı negatifse, negatif olan sayıyı yazdır
                if (intNumber < 0 || doubleNumber < 0)
                {
                    if (intNumber < 0) Console.WriteLine($"Negatif sayı: {intNumber}");
                    if (doubleNumber < 0) Console.WriteLine($"Negatif sayı: {doubleNumber}");
                }
                // Her iki sayı pozitifse, küçük olanın tersini (1/sayı) yazdır
                else if (intNumber > 0 && doubleNumber > 0)

                {
                    if (intNumber > doubleNumber)
                    {
                        Console.WriteLine(1.0 / doubleNumber);
                    }
                    else
                    {
                        Console.WriteLine(1.0 / intNumber);
                    }



                }
            }

            Console.WriteLine("Lütfen bir int değeri giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen bir double değeri giriniz: ");
            double y = double.Parse(Console.ReadLine());

            // PrintNumbers metodunu çağırıyoruz
            PrintNumbers(x, y);
            */

            // 11. soru
            /*
            static double medyanbulma(params int[] values)
            {
                Array.Sort(values); 
                int n = values.Length;
                if (n % 2 == 1) 
                {
                    return values[n / 2];
                }
                else 
                {
                    return (values[(n - 1) / 2] + values[n / 2]) / 2.0;
                }
            }

            Console.WriteLine("Lütfen dizinin kaç adet oldgunu giriniz giriniz");
            int sayım = Convert.ToInt32(Console.ReadLine());
            int[] dizim = new int[sayım];
            for (int i = 0; i < dizim.Length; i++)
            {
                Console.WriteLine($"{i}. değeri giriniz :  ");
                dizim[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine(medyanbulma(dizim));
            */
            //12. soru
            /*
            static double karealma(ref int x)
            {

                double karesi = x * x;
                return karesi;
            }

            int x = 4;
            Console.WriteLine(karealma(ref x));
            */
            /// 13. sru

            /*
            List<int> yendizim = new List<int>();
            Random rastgele = new Random();

            for (int i = 0; i < 5 ; i++)
            { 
                int yenisayi = rastgele.Next(1,50);
                yendizim.Add(yenisayi);
                
            }
            double toplam=0;
            double ortalama;
            for (int i = 0;i < 5 ; i++)
            {

                toplam += yendizim[i];
                
            }
            ortalama = toplam / 5;

            for (int i = 0; i<5; i++)
            {

                if (yendizim[i] > ortalama )
                {
                    Console.WriteLine(yendizim[i]);
                }

            }
            */


            /// 14. soru
            /// 

            /*
            static List<string> edöndürenliste(List<string> list, string targetchar)
            {
                List<string> result = new List<string>();
                foreach (string str in list)
                {
                    if (str.Contains(targetchar))
                    {
                        result.Add(str);
                    }
                }
                return result;
            }

            List<string> listem =new List<string> { "furkan", "araba", "elma" ,"erik" , "keltoş"};
            string istenenharf = "e";

            List<string> result = edöndürenliste (listem, istenenharf);

            foreach (string str in result)
            {
                Console.WriteLine (str);
            }
            */
            /// 15. soru
            /// 
            /*
            Dictionary<string, int> öğrencilerventolar = new Dictionary<string, int> { { "Furkan" , 90}  ,{"Elif ", 50}  ,{"Mahmut" , 40}};
            Console.WriteLine("Lütfen notunu öğrenmek istediğiniz öğrenicinin aıdnı giriniz : ");
            string öğrenciAdı = Console.ReadLine();

            if (öğrencilerventolar.ContainsKey(öğrenciAdı))
            {
                int not = öğrencilerventolar[öğrenciAdı];
                Console.WriteLine($"{öğrenciAdı} adlı öğrencinin notu: {not}");
            }
            else
            {
                Console.WriteLine($"{öğrenciAdı} adlı öğrenci bulunamadı.");
            }

            */























        }

            
    }
}

