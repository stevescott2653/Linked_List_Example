using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Example
{
    public class LinkedListExample
    {
        public static void Main(string[] args)
        {
            // Create a list of strings
            var names = new LinkedList<string>();
            names.AddLast("Chris");
            names.AddLast("Linda");
            names.AddLast("Sharron");
            names.AddLast("Amber");
            names.AddFirst("Frank"); // added to first index

            // Iterate list elements using foreach loop
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
