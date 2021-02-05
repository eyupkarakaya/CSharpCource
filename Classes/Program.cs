using System;

namespace Classes
{
    class Program
    {
        // classları gruplara ayırmak , işlemler yapmak ve ulaşmak için kullanılır
        // bir class oluştururken tabi kelimelerin ilk harfi  büyük olmasına Pascal Case denir
        
        static void Main(string[] args)
        {
            //classın örneği olduğunda (customerManager) ilk harfi küçük bu da Camel case
            CustomerManager customerManager = new CustomerManager(); //CustomerManager classı
            customerManager.Add();
            customerManager.Update();
            //new deyimi, nesneleri oluşturmak yada daha önceden oluşturulmuş olan nesneleri çağırmak için kullanılır. 
            //Property nesneleri tutmak özellikleri tutan
            ProductManager productManager = new ProductManager(); //ProductManager classı
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Diyarbakır";
            customer.Id = 11;
            customer.FirstName = "Eyüp"; //Bu classın  ( public string FirstName { get; set; }) buradaki set edilir kurulur
            customer.LastName = "Karakaya";

            Customer customer2 = new Customer
            {
                //bu kullanım ile üstteki aynı
                Id =11,FirstName="Eyüp",LastName="Karakaya",City="Diyarbakır"          
            };
            //burada ise public string FirstName { get; set; } get kullanım bu yani customer2.FirstName
            Console.WriteLine(customer2.FirstName);
        }      
    }
}
