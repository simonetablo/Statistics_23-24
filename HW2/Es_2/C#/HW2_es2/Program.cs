using System;
using System.Collections.Generic;

namespace HW2_es2
{
    class Program
    {
        static void Main()
        {
            // Array
            int[] array = { 1, 2, 3, 4, 5 };
            array[0] = 10; // Set value
            Console.WriteLine(array[0]); // Get value
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            // List
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            list.Add(6); // Add value
            list.Remove(1); // Remove value
            Console.WriteLine(list.Contains(2)); // Check existence
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Dictionary
            Dictionary<int, string> dictionary = new Dictionary<int, string> { { 1, "one" }, { 2, "two" }, { 3, "three" } };
            dictionary.Add(4, "four"); // Add key-value pair
            dictionary.Remove(1); // Remove key-value pair
            Console.WriteLine(dictionary.ContainsKey(2)); // Check key existence
            Console.WriteLine(dictionary.ContainsValue("three")); // Check value existence
            foreach (var item in dictionary)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            // SortedList
            SortedList<int, string> sortedList = new SortedList<int, string> { { 1, "one" }, { 2, "two" }, { 3, "three" } };
            sortedList.Add(4, "four"); // Add key-value pair
            sortedList.Remove(1); // Remove key-value pair
            Console.WriteLine(sortedList.ContainsKey(2)); // Check key existence
            Console.WriteLine(sortedList.ContainsValue("three")); // Check value existence
            foreach (var item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            // HashSet
            HashSet<int> hashSet = new HashSet<int> { 1, 2, 3, 4, 5 };
            hashSet.Add(6); // Add value
            hashSet.Remove(1); // Remove value
            Console.WriteLine(hashSet.Contains(2)); // Check existence
            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }

            // SortedSet
            SortedSet<int> sortedSet = new SortedSet<int> { 1, 2, 3, 4, 5 };
            sortedSet.Add(6); // Add value
            sortedSet.Remove(1); // Remove value
            Console.WriteLine(sortedSet.Contains(2)); // Check existence
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);
            }

            // Queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1); // Add value to the end of the queue
            queue.Dequeue(); // Remove and return the first value of the queue

            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());

            // Stack
            Stack<int> stack = new Stack<int>();
            stack.Push(1); // Add value to the top of the stack
            stack.Pop(); // Remove and return the top value of the stack

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());

            // LinkedList
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(1); // Add value to the end of the linked list
            linkedList.RemoveFirst(); // Remove the first node of the linked list

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }

}