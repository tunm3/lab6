﻿using System;

namespace Part1_1
{
    internal abstract class Program
    {
        public delegate void Increment(ref int X);

        public static void Add2(ref int x)
        {
            x += 2;
        }
        
        public static void Add3(ref int x)
        {
            x += 3;
        }
        public static void Main(string[] args)
        {
            Increment functionDelegate = Add2;
            functionDelegate += Add3;
            functionDelegate += Add2;
            int x = 5;
            functionDelegate(ref x);
            Console.ReadLine();
        }
    }
}