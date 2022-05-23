using System;

namespace CollectionsDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CollectionDemo");
            Collections col = new Collections();
            col.doListDemo();
            col.doDictionaryDemo();
            col.doStackDemo();
            col.doQueueDemo();
            col.doSetDemo();
        }
    }
}