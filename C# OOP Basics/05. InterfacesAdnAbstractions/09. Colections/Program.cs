using _09._Colections.Models;
using System;
using System.Collections.Generic;

namespace _09._Colections
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddCollection<string> addCollection = new AddCollection<string>();
            AddRemoveCollection<string> addRemoveCollection = new AddRemoveCollection<string>();
            MyList<string> myList = new MyList<string>();

            List<int> addResults = new List<int>();
            List<int> addRemoveResults = new List<int>();
            List<int> myListResults = new List<int>();

            List<string> addRemove_removed = new List<string>();
            List<string> myList_removed = new List<string>();

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach(string item in input)
            {
                addResults.Add(addCollection.Add(item));
                addRemoveResults.Add(addRemoveCollection.Add(item));
                myListResults.Add(myList.Add(item));
            }

            int elementsToRemove = int.Parse(Console.ReadLine());

            for(int i = 0; i < elementsToRemove; i++)
            {
                addRemove_removed.Add(addRemoveCollection.Remove());
                myList_removed.Add(myList.Remove());
            }

            Console.WriteLine(string.Join(" ",addResults));
            Console.WriteLine(string.Join(" ", addRemoveResults));
            Console.WriteLine(string.Join(" ",myListResults));
            Console.WriteLine(string.Join(" ",addRemove_removed));
            Console.WriteLine(string.Join(" ",myList_removed));
        }
    }
}
