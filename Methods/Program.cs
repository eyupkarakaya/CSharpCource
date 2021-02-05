using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add(); //Method bu 
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2(5,15); //methot çağırma
            //Console.WriteLine(result); //sonucu ekrana yazdır

            // <------------- bu işaret ile yorum satırı yazıyoruz. 
            // <-------------  bunun kısa yolu yorum satırı yapılacak olan seçilir önce (CTRL + K ) ve sonra (CTRL + C)

            // int number1 = 20; //number değişkenine  20 değerini atadık
            // int number2 = 100; //number2 100 değerini atadık
            //var result2 = Add3(ref number1, number2); //ref keyword olarak gönderdek metho içindeki değeri alır 
            //Console.WriteLine(result2); //sonucu ekrana yazdır
            //Console.WriteLine(number1); //değer tip olduğu için methodaki atanan değer önemli değil


            Console.WriteLine( Multiply(2,4));
            Console.WriteLine(Multiply2(2 , 4 , 5));
            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine(); // ekranda sabitle
        }

        static void Add()
        {
            Console.WriteLine("Added???");
        }
        static int  Add2(int number1= 10 , int number2 =30) //Default parametre numberden sonra sayı yazma
        {
              //default değerleri her zaman method sonuna yazılır
                var  result= number1 + number2;
            return result; //sonucu döndür
        }

        static int Add3(ref int number1 , int number2)
        {
            number1 = 50; //ref keyword ile bu değer yazılır
            return number1 + number2;         
        }
        static int Multiply(int number1, int number2) // methodun imzası
        {
            return number1 * number2;
        }
        static int Multiply2(int number1, int number2,int number3)
        {
            return number1 * number2 * number3; //aşırı yüklenme overloading
         }

        // params 
        static int Add4(params int[] numbers) //params keyword dizi formatında birden çok parametre gönderillir ve ayrıca en son parametre olmak zorunda
        {
            return numbers.Sum();
        }
    }
}
