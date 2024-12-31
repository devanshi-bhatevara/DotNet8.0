using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DotNet8._0
{
    public class CollectionExpressions
    {
        public static void CollectionExpressionsDemo() 
        {
           int[] myArray = [ 1, 2, 3 ];
           List<int> myList = [1, 2, 3];
           Span<int> mySpan = [1, 2, 3];


            Console.WriteLine($"{nameof(myArray)}: {JsonSerializer.Serialize(myArray)}");
            Console.WriteLine($"{nameof(myList)}: {JsonSerializer.Serialize(myList)}");
            Console.Write($"{nameof(mySpan)}: ");
            foreach (var item in mySpan) Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}
