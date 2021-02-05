using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        //bir müşterinin özelliklerini tutmak için kullanılır
        //bu özelliklere property denir


        //bir alan field tanımlamak
        // public string FirstName; 
        // property 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        //Aşağıdaki işlem ise encapsulation (kapsülleme) get ve set içine istediğimizi yazma
        //private string _firstName; //bir field tanımla
        //public string FirstName //
        //{
        //    get { return "Mr." + _firstName; }    //müsteri okuyunca Mr. başa eklenir
        //    set { _firstName = value; }
        //}
    }
}
