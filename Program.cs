//properties
using System;
using System.Net.WebSockets;

namespace properties
{

    public class Employee
    {
        public static double bonus = 1500; //static data
        public const double taxrate = 0.2; //const value 
        private string name; //field 
        private double wage;
        public string Name //properties
        {
           //get => name;
           // set => name = value;
           get { return name; }
            set { name = value; }
        }

        public double Wage
        {
            get { return wage; }
            set
            {
                if (value < 0)
                {
                    wage = 0;
                }
                else
                {
                    wage = value;
                }

            }   
        }
    }

    static class Product
    {
        public static int productId;
        public static string productName;
        public static int productPrice;

        static Product(){
             productId=111;
             productName="Guitar";
            productPrice = 5000;
        }
        public static void ProductDetails()
        {
            Console.WriteLine("productId = {0}", productId);
            Console.WriteLine("productName = {0}", productName);
            Console.WriteLine("productPrice = {0}", productPrice);
        }
        public static void ProductDiscount() {
            int d_amount = productPrice / 10;
            Console.WriteLine("Your discount ammount is {0}: ", d_amount);
            Console.WriteLine("Your final price is {0}:", (productPrice - d_amount));

        }
            
      


    }

    public class Employee2
    {
        static void Main(string[] args)
        {
            //nullable
            string a = null;
            int? b = null;
            int c = b ?? 20;


            Employee s = new Employee();
            s.Name = "Kavita";
            s.Wage = -70000;
            Console.WriteLine(s.Name);
            Console.WriteLine(s.Wage);
            Console.WriteLine(Employee.bonus);
            Console.WriteLine(c);

            //calling static class
            Product.ProductDetails();
            Product.ProductDiscount();
            
            Console.ReadLine();

        }
    }
}
