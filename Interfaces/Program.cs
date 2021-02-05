using System;

namespace Interfaces
{
    class Program
    {


        static void Main(string[] args)
        {
            //Interfaces ve abtract hiç bir zaman newlenemez
            //
            //InterfacesIntro();
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3] 
            {
                new SqlServerCustomer(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                customerDal.Delete();
                customerDal.Update();
            }
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Eyüp",
                LastName = "Karakaya",
                Address = "Diyarbakır"
            };


            Student student = new Student
            {
                Id = 121,
                FirstName = "Gamze",
                LastName = "Yaman",
                Departmant = "Bilgisayar Bilimleri"
            };

            Worker worker = new Worker
            {
                Id = 11,
                FirstName = "Ceren",
                LastName = "Ateş",
                Departmant = "Modacı "
            };
            manager.Add(customer);
            manager.Add(student);
            manager.Add(worker);
        }

        //En büyük kullanım amacı bir temel operasyon , temel nesne oluşturup implemente etmektir
        //Bu soyut nesnelerdir tek başına anlama ifade etmez
        interface IPerson
        {
            //interface yazılırsa void int imzası yazılır
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }
        //Bu somut nesnelerdir
        class Customer : IPerson //bunun anlamı IPerson tanımlananları görebiliriz
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Address { get; set; }
        }
        //Bu somut nesnelerdir
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Departmant { get; set; }
        }
        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Departmant { get; set; }
        }
        //Manager olunca iş katmanı sınıfı
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
