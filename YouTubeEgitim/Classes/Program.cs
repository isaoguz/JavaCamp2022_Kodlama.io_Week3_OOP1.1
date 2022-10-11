using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CreditManager creditManager = new CreditManager();
            //creditManager.Calculate();
            //creditManager.Save();

            //Console.WriteLine("********************************************************");

            //Customer customer = new Customer();
            //customer.id = 1;



            //CustomerManager customerManager = new CustomerManager(customer);  //Örneğini oluşturmak intiance oluşturmak
            //customerManager.Save();
            //customerManager.Delete();

            //Console.WriteLine("********************************************************");


            //Company company = new Company();
            //company.TaxNumber = "1314134134";
            //company.CompanyName = "Beko";
            //company.id = 23;

            //CustomerManager customerManager2 = new CustomerManager(company);

            //Console.WriteLine("********************************************************");

            //Customer c1 = new Customer();
            //Customer c2 = new Person();
            //Customer c3 = new Company();




            //INTERFACES


            //IoC Continer
            CustomerManager customerManager = new CustomerManager(new Person(),new TeacherCreditManager());
            customerManager.GiveCredit();













            
        }

        //SOLİD
        //Katmanlı Mimariler

        class CreditManager
        {
            
            public void Calculate()
            {
                Console.WriteLine("Calculate");
            }

            public void Save()
            {
                Console.WriteLine("Saved");
            }
            
        }


        interface ICreditManager
        {
            void Calculate();
            void Save();

        }

        public abstract class BaseCreditManager : ICreditManager
        {
            public abstract void Calculate();

            public virtual void Save()
            {
                Console.WriteLine("Kaydedildi");
            }
        }

        class TeacherCreditManager : BaseCreditManager, ICreditManager
        {
            public override void Calculate()
            {
                //hesaplamalar
                Console.WriteLine("Öğretmen kredisi hesaplandı.");
            }

            public override void Save()
            {
                Console.WriteLine("Kayded Kanka");
            }
        }

        class MilitaryCreditManager : BaseCreditManager, ICreditManager
        {
            public override void Calculate()
            {
                Console.WriteLine("Asker kredisi hesaplandı.");

            }

            //public void Save()
            //{
            //    Console.WriteLine("Asker kredisi Kaydedildi.");
            //}
        }

        class CarCreditManager : BaseCreditManager, ICreditManager
        {
            public override void Calculate()
            {
                //hesaplamalar
                Console.WriteLine("Araba kredisi hesaplandı.");
            }

            //public void Save()
            //{
            //    Console.WriteLine("Araba kredisi Kaydedildi.");
            //}
        }

        class Customer
        {
     
            public Customer()
            {
                Console.WriteLine("Müşteri nesnesi başlatıldı.");
            }
            public int id { get; set; }
        

            public string City { get; set; }
        }
        class Person:Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string NationalIdentity { get; set; }

        }

        class Company:Customer
        {
            public string CompanyName { get; set; }
            public string TaxNumber { get; set; }

        }



        class CustomerManager
        {
            private Customer _customer;
            private ICreditManager _creditManager;


            public CustomerManager(Customer customer,ICreditManager creditManager)
            {
                _customer = customer;
                _creditManager = creditManager;
            }
           public void Save()
            {
                Console.WriteLine("Müşteri added " );
            }

            public void Delete()
            {
                Console.WriteLine("Müşteri Deleted ");
            }

            public void GiveCredit()
            {
                _creditManager.Calculate();
                _creditManager.Save();
                Console.WriteLine("Kredi Verildi");
            }
        }
    }
}
