﻿
using Lab4.Algorithm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace Lab4
{
    public class Result
    {
        public int Lenght { get; set; }
        public string? Name { get; set; }
        public string[]? Sorted { get; set; }
        public double Time { get; set; }
        public Dictionary<string, int>? WordsOfCount { get;set; }


        public void PrintSorted()
        {
            Console.WriteLine("Array:");
            foreach (var item in Sorted)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintWordsOfCount()
        {
            Console.WriteLine("Dictionary:");
            foreach (var word in WordsOfCount)
            {
                Console.WriteLine($"Слово '{word.Key}' встречается {word.Value} раз(а).");
            }
        }
    }

    public class AlgorithmProfiler
    {
        private Stopwatch stopWatch;

        public AlgorithmProfiler()
        {
            stopWatch = new Stopwatch();
        }

        public void Run(string[] words, IAlgorithm<string> algorithm)
        {
            stopWatch.Reset();
            stopWatch.Start();
            algorithm.Execute(words);
            stopWatch.Stop();
            Console.WriteLine($"Массив длиной: {words.Length} был отсортирован с помощью {algorithm} за {stopWatch.Elapsed.TotalSeconds}");

        }

        public Result RunExtra(string[] words, IAlgorithm<string> algorithm)
        {
            stopWatch.Reset();
            stopWatch.Start();
            algorithm.Execute(words);
            stopWatch.Stop();

            var dictionary = Count(words);

            return new Result
            {
                Lenght = words.Length,
                Name = algorithm.ToString(),
                Sorted = words,
                Time = stopWatch.Elapsed.TotalSeconds,
                WordsOfCount = dictionary,
            };

        }

        public Dictionary<string, int>? Count(string[] arrayOfwords)
        {
            if (arrayOfwords == null)
            {
                return null;
            }

            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (string word in arrayOfwords)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word] += 1;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }
            return wordCounts;
        }
    }
}
