﻿using System;
using System.Linq;

namespace AssignmentQ_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", Program.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        }
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            return names1.Union(names2).ToArray();
        }
        //sarmad
    }
}
