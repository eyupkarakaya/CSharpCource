using System;

namespace Inheritance
{
    class Program
    {
        //
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            Person[] persons = new Person[3] //person array
            {
               new Customer{FirstName ="Eyüp" }, new Student{FirstName= "Gamze"},new Person{FirstName = "Ceren" }          
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //önce inheratance yazılır
    //classların tek başına anlamını vardır interface tek başına anlamı yok
    class Person2
    {

    }
    class Customer :Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
