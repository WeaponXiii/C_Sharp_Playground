using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Playground.LinqVsGenericBuiltIn
{
    class LinqVsGenericBuiltIn
    {
        public LinqVsGenericBuiltIn()
        {
            List<int> list = [1, 2, 3, 4, 5];

            var list1 = list.Select(x => 2 * x).ToList(); // Better to use with iEnumerable
            var list2 = list.ConvertAll(x => 2 * x); // Specific for already "materialized" list 

            Console.WriteLine("list after Select().ToList()");
            list1.ForEach(x => Console.WriteLine(x));
            Console.WriteLine($"{Environment.NewLine}list2.ForEach(x => Console.WriteLine(x)):");
            list2.ForEach(x => Console.WriteLine(x));

            /*
             The List<T> class contains several methods that has almost exact matches in LINQ. 
                Exists -> Any, Find -> First, FindAll -> Where, FindLast -> Last, TrueForAll -> All  
             ConvertAll is available for arrays too, using the static "Array.ConvertAll(array, converter)"
             */

        }
    }
}
