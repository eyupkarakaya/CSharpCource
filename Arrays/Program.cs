using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //array neden kullanılır
            //string metinsel veri tipi ve referans tiptir
            //string student1 = "Eyüp";
            //string student2 = "Gül";
            //string student3 = "Gamze";

            //string[] students = new String[3] { "Eyüp", "Ali", "Gamze" }; //dizi  eğer int verirse çalışmaz
            //students[0] = "Eyüp";
            //students[1] = "Gamze";
            //students[2] = "Ali";

            //string[] students2= {"Eyüp","Ali","Gamze" };


            ////array referans tiptir

            //foreach (var student in students)     //bir array gezmek için kullanılır
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[4, 3] //regions bölgeler
            {
               { "istanbul","İzmit","Balıkesir"},
               { "Ankara","Konya","Kırıkkale" },
               { "Antalya","Adana","Mersin" },
               { "Rize","Trabzon","Samsun" },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)  //Tek boyutlu bir dizide GetUpperBound() metodu her zaman eleman sayısının bir eksiği değerini verir. 
            {

                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }



            }
        }
    }
            
           
        
        
    
}
