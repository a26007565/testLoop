using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace testLoop {
    [RPlotExporter, RankColumn]
    public class LoopBenchmarks {
        static readonly int[] Arr = new int[10];

        public LoopBenchmarks () {
            for (var i = 0; i < Arr.Length; i++) {
                Arr[i] = i;
            }
        }

        [Benchmark]
        public int ForEachOnArray () {
            var sum = 0;
            foreach (var val in Arr) {
                sum += val;
            }
            return sum;
        }

        [Benchmark]
        public int ForEachOnIEnumerable () {
            var sum = 0;
            IEnumerable<int> arrEnum = Arr;
            System.Threading.Tasks.Parallel.ForEach (arrEnum, val => {
                sum += val;
            });
            return sum;
        }

        [Benchmark]
        public int LinqSum () {
            return Arr.Sum();
        }

    }

    class Program {
        static void Main (string[] args) {
            var summary = BenchmarkRunner.Run<LoopBenchmarks> ();
        }
    }
}