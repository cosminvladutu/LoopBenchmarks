using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace LoopBenchmark
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Run the benchmark
            BenchmarkRunner.Run<LoopBenchmarks>();
        }
    }

    [MemoryDiagnoser]
    public class LoopBenchmarks
    {
        private List<int> _numbers;

        [GlobalSetup]
        public void Setup()
        {
            // Initialize the list with 100 random ints
            Random random = new Random();
            _numbers = Enumerable.Range(0, 100).Select(_ => random.Next(0, 100)).ToList();
        }

        [Benchmark]
        public int ForLoop()
        {
            int sum = 0;
            for (int i = 0; i < _numbers.Count; i++)
            {
                sum += _numbers[i];
            }
            return sum;
        }

        [Benchmark]
        public int WhileLoop()
        {
            int sum = 0;
            int i = 0;
            while (i < _numbers.Count)
            {
                sum += _numbers[i];
                i++;
            }
            return sum;
        }
    }
}
