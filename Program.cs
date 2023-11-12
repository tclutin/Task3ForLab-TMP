using Lab4.Algorithm;
using Lab4.Algorithm.Sort;
using System.Linq.Expressions;

namespace Lab4
{
    public class Program
    {

        public static void Main(string[] args)
        {

            AlgorithmProfiler profiler = new AlgorithmProfiler();
            string[] words = "BUGAGA AR CQ HD DB DA DB BUGAGA".Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            //string[] words1 = "BUGAGA AR CQ HD DB DA DB BUGAGA".Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var x = profiler.RunExtra(words, new InsertionSortAlgorithm());
            x.PrintSorted();
            x.PrintWordsOfCount();



        }
    }
}