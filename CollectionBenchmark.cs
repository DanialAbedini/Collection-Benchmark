using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace Collection
{
    [MemoryDiagnoser]
    public class CollectionBenchmark
    {
        private const int CollectLenght = 1000000;
        private readonly int[] array;
        private readonly List<int> list;
        private readonly HashSet<int> hashset;
        private readonly SortedSet<int> sortedset;
        private readonly IEnumerable<int> enumrable;
        private readonly Dictionary<int, int> dict;
        private readonly LinkedList<int> linklist;
        private readonly Queue<int> queue;
        private readonly Stack<int> stack;

    }
}