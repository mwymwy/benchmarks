using benchmark_lib;

namespace lib_test
{
    public class BenchmarkTest
    {
        private static Benchmark? benchmark;

        [SetUp]
        public void Setup()
        {
            benchmark = new Benchmark();

            var processSleep100ms = () => { Thread.Sleep(100); };
            var processSleep200ms = () => { Thread.Sleep(200); };

            benchmark.AddBenchmark("100 ms", processSleep100ms);
            benchmark.AddBenchmark("200 ms", processSleep200ms);
        }

        [Test]
        public void RunBenchmark_ShouldCompleteNormally()
        {
            //Arrange

            //Act

            //Assert
            Assert.Fail();
        }

        [Test]  
        public void CompareResults_ShouldTellFastest()
        {
            //Arrange

            //Act

            //Assert
            Assert.Fail();
        }
    }
}