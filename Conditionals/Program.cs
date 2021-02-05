using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 20;

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                
            }

            //Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
            //if (number == 10)
            //{
            //    Console.WriteLine("Number is 10");
            //}
            // else if (number ==34)
            //{
            //    Console.WriteLine("Number is 34");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10");
            //}
            ////switch (number)




            if (number < 100)
            {
                if (number >= 90 && number < 100)
                {

                }
            }



            Console.ReadLine();
        }
    }
}
