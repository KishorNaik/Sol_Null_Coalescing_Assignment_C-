using System;
using System.Collections.Generic;

namespace Sol_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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
