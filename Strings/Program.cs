using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //metinsel veri tipidir
            string city = "Adana"; //aynı zamanda bir char  array dır

            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "Kebabı";
            //string result = city + " " + city2;
            Console.WriteLine(String.Format("{0} {1}",city,city2)); //format ile ekstra değişken gerek kalmaz

            string sentence = "Bu benim dünyam";
            var result = sentence.Length;              //cümlenin kaç karakter olduğunu söyler
            var result2 = sentence.Clone();       //clon yapmak için kullanılır

            sentence = "Her şey seninle başlar";
            bool result3 = sentence.EndsWith("m"); // bu cümle  m ile bitiyor mu
            bool result4 = sentence.StartsWith("B"); // bu cümle  B ile başlıyor  mu

            var result5 = sentence.IndexOf("başlar");   // belli bir karakteri veya ifadeyi arar sayı verir
            var result6 = sentence.IndexOf(" "); 
            var result7 = sentence.LastIndexOf("Her");// belli bir karakteri veya ifadeyi arar sondan gelir
            var result8 = sentence.Insert(0,"Merhaba ,");   //bir cümleye veya string ifadeye başka metin yerleştirir
            var result9= sentence.Substring(3,4);  //metni parçalamak için kullanılır
            var result10 = sentence.ToLower();//bütün karakterleri küçük harfe çevirir
            var result11 = sentence.ToUpper();//bütün karakterleri büyük harfe çevirir
            var result12 = sentence.Replace(" ","-"); //bir metin içinde karakter değiştirme
            var result13 = sentence.Remove(3,3); //belirlenen karakterden sonrakini kaldırır
            
            Console.WriteLine(result13);



        }





    }
}
