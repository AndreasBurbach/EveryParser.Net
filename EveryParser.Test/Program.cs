﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EveryParser.Test
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //var mathTest = new ExpressionTest.ExpressionMathTest();
            //mathTest.DefaultTests();
            //mathTest.FactorConstTest();
            //mathTest.FactorTests();
            //mathTest.FunctionTests();

            //var mathArrayTest = new ExpressionTest.ExpressionMathArrayTest();
            //mathArrayTest.MathArrayTests();
            //mathArrayTest.MathStatisticsArrayTests();
            LinqPerformanceTest();
            Console.ReadLine();
        }

        private static void LinqPerformanceTest()
        {
            var timer = new Stopwatch();
            timer.Start();
            timer.Stop();

            var testList = new List<int>(1000000);
            for (int i = 0; i < 1000000; ++i)
                testList.Add(i);

            timer.Start();
            OwnAny(testList);
            timer.Stop();
            Console.WriteLine("Time own Any default function.: " + timer.Elapsed);

            timer.Start();
            testList.Any();
            timer.Stop();
            Console.WriteLine("Time linq Any default function.: " + timer.Elapsed);

            timer.Start();
            OwnAny(testList, x => x > 500000);
            timer.Stop();
            Console.WriteLine("Time own Any expression function.: " + timer.Elapsed);

            timer.Start();
            testList.Any(x => x > 500000);
            timer.Stop();
            Console.WriteLine("Time linq Any expression function.: " + timer.Elapsed);


            timer.Start();
            OwnSelect(testList, x => x * 5);
            timer.Stop();
            Console.WriteLine("Time own Select expression function.: " + timer.Elapsed);

            timer.Start();
            testList.Select(x => x * 5).ToList();
            timer.Stop();
            Console.WriteLine("Time linq Select expression function.: " + timer.Elapsed);
        }

        public static bool OwnAny(List<int> list)
        {
            return list.Count > 0;
        }

        public static bool OwnAny(List<int> list, Func<int, bool> expression)
        {
            foreach (var x in list)
                if (expression.Invoke(x))
                    return true;

            return false;
        }

        public static List<int> OwnSelect(List<int> list, Func<int, int> expression)
        {
            var result = new int[list.Count];
            for (int i = 0; i < result.Length; i += 1)
                result[i] = expression.Invoke(list[i]);

            return new List<int>(result);
        }
    }
}