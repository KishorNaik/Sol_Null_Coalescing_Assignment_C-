using System;
using System.Collections.Generic;

namespace Sol_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Basic Null_Coalescing_Operator
            string item_1 = null;
            string item_2 = null;
            string item_3 = "Hello C#";

            string result = null;

            result = item_1 ?? item_2 ?? item_3;

            Console.WriteLine(item_1); // NulL
            Console.WriteLine(item_2); // Null
            Console.WriteLine(item_3); // Hello C#
            Console.WriteLine(result); // Hello C#

            // Basic Null_Coalescing_ Assignment Operator
            string item_4 = null;
            string item_5 = null;
            string item_6 = "Hello C#";

            result = item_4 ??= item_5 ??= item_6;

            Console.WriteLine(item_4); // Hello C#
            Console.WriteLine(item_5); // Hello C#
            Console.WriteLine(item_6); // Hello C#
            Console.WriteLine(result); // Hello C#






            // using Null_Coalescing_Operator
            List<String> list = null;

            list = (list ?? new List<string>());
            list.Add("Hello");
            Console.WriteLine(list?.Count); // 1;

            list = null;
            // use Without passing list object using Null_Coalescing_Operator
            (list ?? new List<string>())
                .Add("Hello"); // still it is null becuase object not bound on this context.
            //Console.WriteLine(list.Count); // Object reference not set to an instance of an object.' exception will throw

            // So overcome for this above problem.
            // Null_Coalescing_Operator assignment operator

            (list ??= new List<string>())
                .Add("Hello");
            Console.WriteLine(list?.Count); // 1;


        }
    }
}
