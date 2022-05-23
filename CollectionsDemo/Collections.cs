using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class Collections
    {
        public void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");
            List<string> list = new List<string>();
            list.Add("Mohan");
            list.Add("Vijay");
            list.Add("Kishore");
            list.Add("Vijay");
            foreach (var data in list)
            {
                Console.WriteLine(data);
            }
        }
        public void doStackDemo()
        {
            Console.WriteLine("In doStackDemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Rehan");
            stack.Push("Cheshav");
            stack.Push("Sai");
            stack.Push("Anwar");
            stack.Push("Reena");
            string pop = stack.Pop();
            foreach (var data in stack)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("Popped Element : " + pop);
        }
        public void doQueueDemo()
        {
            Console.WriteLine("\nIn doQueueList");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Nikhil");
            queue.Enqueue("Vijaya");
            queue.Enqueue("Ram");
            queue.Enqueue("Kumar");
            Console.WriteLine("Iterating the queue elements");
            foreach (var data in queue)
            {
                Console.WriteLine(data);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue Elements : " + dequeue);
            Console.WriteLine("\nIterating the Queue Elements After dequeue One Element");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public void doSetDemo()
        {
            Console.WriteLine("\nIn doSetDemo");
            var set = new HashSet<string>();
            set.Add("Harish");
            set.Add("Vinay");
            set.Add("Vijay");
            set.Add("Kishore");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public void doDictionaryDemo()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Deva");
            dictionary.Add(101, "Kishore");
            dictionary.Add(102, "Vijay");
            Console.WriteLine("Access Value Using Key(key=100): " + dictionary[100]);
            Console.WriteLine("\nIterating Dictionary");
            foreach (var data in dictionary)
            {
                Console.WriteLine("Key = " + data.Key + " & Value = " + data.Value);
            }
        }
    }
}
