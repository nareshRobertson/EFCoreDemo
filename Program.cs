using System;
using System.Collections.Generic;
using System.Linq;
using EFCoreDemo.Data;

namespace EFCoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> localcategories = new List<Category>();

            Category objcategory = null;

            var categoryID = 1;

            using (var ctx = new NorthwindContext())
            {
                objcategory = ctx.Categories.SingleOrDefault(y => y.CategoryId == categoryID);

                //Lamda expression
                // Function GetCategory(int CategoryID)  -- Traditional way
               // Where Y.categoryID = 1 
            }

            Console.WriteLine(objcategory.CategoryName);

            foreach (var cat in localcategories)
            {
                Console.WriteLine(cat.CategoryName);
            }

            //Function that returns Hello world
            String Greet()
            {
                return "Hello World";
            }

            //Using Lamda expression 
            Func<string> greet = () => "Hello World";

        }

        

    }
}
