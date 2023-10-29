namespace benchmark_lib
{
    public class Benchmark
    {
        public List<KeyValuePair<string, Action>> Competitors = new List<KeyValuePair<string, Action>>();

        public Benchmark() { }

        public bool AddBenchmark(string name, Action candidateProcess)
        {
            throw new NotImplementedException();
        }

    }
}