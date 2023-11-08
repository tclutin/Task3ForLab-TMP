using Lab4.Algorithm;
using Lab4.Algorithm.Sort;

namespace Lab4
{
    public class Program
    {

        public static void Main(string[] args)
        {
            /*
            AlgorithmProfiler profiler = new AlgorithmProfiler();

            IAlgorithm<string> sort = new BubbleSortAlgorithm();

            string text = "BUGAGA AR CQ HD DB DA DB BUGAGA";
            string[] words = text.Split(' ');

            sort.Execute(words);

            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (string word in words)
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


            foreach (var word in wordCounts)
            {
                Console.WriteLine($"Слово '{word.Key}' встречается {word.Value} раз(а).");
            }
            */
            AlgorithmProfiler profiler = new AlgorithmProfiler();
            string[] words = "BUGAGA AR CQ HD DB DA DB BUGAGA".Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string[] words1 = "BUGAGA AR CQ HD DB DA DB BUGAGA".Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);


            var x = profiler.RunExtra(words, new BubbleSortAlgorithm());

            Console.WriteLine(x.Name);
            Console.WriteLine(x.Lenght);
            Console.WriteLine(x.Time);
            x.PrintSorted();
            x.PrintWordsOfCount();


        }
    }
}