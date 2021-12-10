using System;

namespace Properties_and_indexes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyCollectionOfIntigers collection =
                new MyCollectionOfIntigers(new[] { 1, 2, 3, 4 });

            int min = collection.Min();
            int element = collection[0];
            
        }
    }
}