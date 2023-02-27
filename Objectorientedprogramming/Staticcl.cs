using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    static class product
    {
        public static int ProductId;
        public static string ProductName;
        public static int ProductPrice;

        static product()
        {
            ProductId = 101;
            ProductName = "mobil";
            ProductPrice = 18000;
        }

        public static void getProductDetails()
        {
            Console.WriteLine("Product id "+ ProductId);
            Console.WriteLine("Product Name "+ ProductName);
            Console.WriteLine("Product Price "+ ProductPrice);
        }

        public static void getDiscount()
        {
            int d_amount = ProductPrice / 10;
            Console.WriteLine("Your discount amount is:"+d_amount);
            Console.WriteLine("Total cost of product is"+ (ProductPrice - d_amount));
        }
    }
    class Staticcl
    {
        static void Main(string[] args)
        {
            product.getProductDetails();
            product.getDiscount();
            Console.ReadLine();
        }
    }
}
