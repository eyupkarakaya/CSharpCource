using System;

namespace Loops  //döngüler 
{
    class Program
    {
        static void Main(string[] args)
        {

            if (IsPrimeNumber(10))
            {
                Console.WriteLine("Bu sayı asal  ");
            }
            else
            {
                Console.WriteLine("Bu asal değil");
            }




            //for ve foreach en çok kullanılan döngüdür
            //while şart sağladığı sürece döner
            //sonsuz döngü
            //int number = 11;
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;

            //} while (number>0);  //while döngüden farklı olaral do tarar


            //    int number = 100;

            //    while (number >= 100)
            //    {
            //        Console.WriteLine(number);
            //        number--;
            //    }
            //    Console.WriteLine();

            //    for (int i = 100; i >= 0; i-=2) //int i=0 başlangıc değeri , i<100 şart sağladığı sürece , i++ her süreçte bir arttır i+=2 ile i=i+2 aynı
            //    {

            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine("bitti");
            //}
            //private static void ForLoop()
            //{
            //    for (int i = 100; i >= 0; i -= 2)  
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //foreach dizi temelli dataların dolaşılması için kullanılır


            //içinde buluduğu sınıftan nesne oluşturulmadan veya hiç bir nesneye referans olmadan kullanılabilen üyeler static olarak nitelendirilir. 
            static bool IsPrimeNumber(int number)
            {
                bool result=true; // sonucu tut

                for (int i = 2; i < number-1; i++)
                {
                    if (number %i ==0)
                    {
                        result = false;
                        i = number;
                    }
                }
                return result;
            }

            //string[] students = new String[3] { "Eyüp", "Ali", "Gamze" };


            //foreach (var student in students) //students içindeki "Eyüp", "Ali", "Gamze" sırayla bunlar gelir
            //{
            //    //student = "Ada"; foreach içinde değişmez
            //    Console.WriteLine(student);
            //}
        }

    }
    
}

