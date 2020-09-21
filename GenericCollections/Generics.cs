using System;
using System.Collections.Generic;
namespace GenericCollections
{
    class Generics
    {
        private void listMethod()
        {
            List<int> listOne = new List<int>();
            foreach (int num in new int[5] { 1, 2, 3, 4, 5 })
            {
                listOne.Add(num);
            }
            Console.WriteLine("1. List \n");
            for (int i = 0; i < listOne.Count; i++)
            {
                int num = listOne[i];
                Console.WriteLine(num);
            }
            Console.WriteLine("..................");
        }
        private void linkedMethod()
        {
            LinkedList<string> listOne = new LinkedList<string>();
            Console.WriteLine("2. Linked List \n");
            foreach (string one in new string[5] { "First", "Second", "Third", "Fourth", "Fifth" })
            {
                listOne.AddFirst(one);
            }
            foreach (string one in listOne)
            {
                Console.WriteLine(one);
            }

            Console.WriteLine("................");
        }
        private void queueMethod()
        {
            Queue<int> queueOne = new Queue<int>();
            Console.WriteLine("3. Queue \n");
            foreach (int num in new int[5] { 1, 2, 3, 4, 5 })
            {
                queueOne.Enqueue(num);
                Console.WriteLine(num);
            }
            Console.WriteLine("..................");
        }
        private void stackMethod()
        {
            Console.WriteLine("4. Stack \n");
            Stack<string> stackOne = new Stack<string>();
            foreach (var stack in new string[5] { "1st", "2nd", "3rd", "4th", "5th" })
            {
                stackOne.Push(stack);
            }
            foreach (var stack in stackOne)
            {
                Console.WriteLine(stack);
            }

            Console.WriteLine("..................");
        }
        private void dictionaryMethod()
        {
            Console.WriteLine("5. Dictionary\n");
            Dictionary<string, int> dictOne = new Dictionary<string, int>();
            dictOne.Add("First", 1);
            dictOne.Add("Second", 2);
            dictOne.Add("Third", 3);
            dictOne.Add("Fourth", 4);
            dictOne.Add("Fifth", 5);
            foreach (KeyValuePair<string, int> variable in dictOne)
            {
                string str = variable.Key;
                int num = variable.Value;
                Console.WriteLine($"{str}, {num}");
            }
            Console.WriteLine("..................");
        }
        private void sortMethod()
        {
            Console.WriteLine("6. Sorted List\n");
            SortedList<int, string> sortOne = new SortedList<int, string>();
            sortOne.Add(1, "First");
            sortOne.Add(2, "Second");
            sortOne.Add(3, "Third");
            sortOne.Add(4, "Fourth");
            sortOne.Add(5, "Fifth");
            foreach (KeyValuePair<int, string> variable in sortOne)
            {
                int num = variable.Key;
                string str = variable.Value;
                Console.WriteLine($"{num}, {str}");
            }
            Console.WriteLine("..................");
        }
        private void hashMethod()
        {
            HashSet<string> hashOne = new HashSet<string>(new string[5] { 
                "1"
                , "2"
                , "3"
                , "4"
                , "5"
            });
            Console.WriteLine("7. HashSet\n");
            foreach (var hope in hashOne)
            {
                Console.WriteLine(hope);
            }
        }
        public void Run()
        {
            listMethod();
            linkedMethod();
            queueMethod();
            stackMethod();
            dictionaryMethod();
            sortMethod();
            hashMethod();
        }
    }
}
