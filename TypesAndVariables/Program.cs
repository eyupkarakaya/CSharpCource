using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            //int Valuse Types - Değer tipdir         
            //condition - şart/koşul
            //byte : Uzunluğu 1 byte’tır, 0 ile 255 arasında değer alır.
            //sbyte : Uzunluğu 1 byte’tır, -128 ile 127 arasında değer alır.
            //short : Uzunluğu 2 byte’tır, -32768 ile 32767 arasında değer alır.
            //ushort : Uzunlupu 2 byte’tır, 0 ile 65535 arasında değer alır.
            //int : Uzunluğu 4 byte’tır, -2.147.483.648 ile 2.147.483.648 arasında değer alır.
            //uint : Uzunluğu 4 byte’tır, 0 ile 4.294.967.295 arasında değer alır.
            //long : Uzunluğu 8 byte’tır, -1020 ile 1020 arasında değer alır.
            //ulong : Uzunluğu 8 byte’tır, 0 ile 2 x 1020 arasında değer alır.
            //float : Uzunluğu 4 byte’tır, 1.5 x 10 - 45 ile 3.4 x 1038 arasında değer alır.
            //double : Uzunluğu 8 byte’tır, 5.0 x 10 - 324 ile 1.7 x 10308 arasında değer alır.
            //decimal : Uzunluğu 12 byte’tır, ±1.0 x 10 - 28 ile ±7.9 x 1028 arasında değer alır.
            //char : Uzunluğu 2 byte’tır, Bütün ınicode karakterleri kapsar.
            //string : Tek bir karakter, sözcük veya cümle gibi değerlerin saklanmasında kullanılır.
            //boolean : True – false değer tutan tiptir.
            //Enum Veri Tipi : Enum, sabitlerle tanımlanmış ayırt edici bir veri tipidir.Enum kullanmanın en temel amacı, programlamada "magic string" denilen değerler tutmak yerine bir Enum sabiti ile bu değerleri getirmektir.
            //Enumeration (enum): Numaralandırma


            // ref kullanımı
            //Metodu tanımlarken geçilmek istenen değişkenin önüne "ref" yazılmalıdır.
            //Bir değişkenin metoda parametre olarak geçilmeden önce bir başlangıç değeri almak zorundadır.

            // out kullanımı
            //Metodu tanımlarken geçilmek istenen değişkenin önüne "out" yazılmalıdır.
            //Bir değişkenin metoda parametre olarak geçilmeden önce bir başlangıç değeri almak zorunda değildir.

            string days = "Monday"; 
            decimal number6 = 10;
            double number5 = 10.4;
            char character = 'A' ; //
            string city = "Siverek";
            bool condition = false; 
            byte number4 = 0;
            short number3 = -32768;
            int number1 = 2147483647;
            long number2 = -9223372036854775807;
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine("Number1 is {0}" ,number1); //number1 ekrana yazdır
            Console.WriteLine("Number2 is {0}", number2); //number2 ekrana yazdır
            Console.WriteLine("Number3 is {0}", number3); //number3 ekrana yazdır
            Console.WriteLine("Number4 is {0}", number4); //number4 ekrana yazdır
            Console.WriteLine("Number5 is {0}", number5); //number5 ekrana yazdır
            Console.WriteLine("Number7 is {0}", number7); //number7 ekrana yazdır
            Console.WriteLine("Character is : {0}", (int) character); // karakteri yazdır
            Console.WriteLine((int)Days.Friday); //enum günleri yazdır
        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesday,Thursday,Friday, Saturday,Sunday
    }
}
