using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Objectorientedprogramming
{
    class Collectionhash
    {
        static void Main(string[]args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("id", 1111);
            ht.Add("name","imran");
            ht.Add("designation", "owner");
            ht.Add("salary", "70000");
            ht.Add("age", 21);
            Console.WriteLine("---------------------------");
            Console.WriteLine(ht.ContainsValue("imran"));//true only see name
            Console.WriteLine("imran".GetHashCode());//code
            Console.WriteLine(ht.Count);//count all
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + " : " + ht[key]);
            }
            Console.WriteLine("------------------------------");
            ht.Remove("salary");
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + " : " + ht[key]);
            }
            ht.Clear();
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + " : " + ht[key]);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine(  ht.Contains("mobileno"));//false
            Console.WriteLine("------------------------------");
            Console.WriteLine(ht.ContainsKey("mobileno"));//false  same as contains
            Console.WriteLine("------------------------------");
            
            Console.ReadLine();


        }
    }
}
