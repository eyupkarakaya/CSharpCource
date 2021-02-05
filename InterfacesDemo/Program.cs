using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker [ ] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker(),
              
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }



        }
    }
    interface IWorker
    {
        //SOLID 
        //1. (S) ingle Responsibility Principle : Tek sorumluluk anlamına gelen bu kuralın amacı projede bir değişiklik yapılmak istendiğinde buna bağlı olarak nelerin etkileneceği düşüncesinden kurtulmak ve özgürce isteğimiz geliştirmeyi yapabilmemize olanak sağlamaktır. 
        //2. (O) pen/Closed Principle : Açık kapalı prensibi projemizdeki nesnelerin geliştirmeye açık ama değişime kapalı olmaları anlamına gelmektedir. 
        //3. (L) iskov ‘s Substitution Principle : Yerine geçme prensibi kalıtım alarak türeyen sınıfların kalıtım aldıkları nesnenin tüm özellikleri kullanmalı ve sonrasında kendi özelliklerini barındırmasını hedefleyen bir prensiptir 
        //4. (I) nterface Segregation Principle : Arayüz ayırım prensibi, bir arayüze gerektiğinden fazla yetenek eklenmemesi gerektiğini söyler. 
        //5. (D) ependency Inversion Principle : Bağımlılığın ters çevirilmesi ilkesine göre üst seviye sınıflar, modüller, methodlar vs. alt seviyeli sınıflara bağımlı olmamalıdır. 
        //Çalışır-yemek yer - maaş alır
        void Work();       
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    //Bir clasın birden fazla interface implement edebilir
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
