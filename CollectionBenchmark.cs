using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Extensions;

namespace Collection
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class CollectionBenchmark
    {
        private const int Len = 10000;
        private readonly int[] array;
        private readonly List<int> list;
        private readonly HashSet<int> hashset;
        private readonly SortedSet<int> sortedset;
        private readonly IEnumerable<int> enumrable;
        private readonly Dictionary<int, int> dict;
        private readonly LinkedList<int> linklist;
        private readonly Queue<int> queue;
        private readonly Stack<int> stack;
        private readonly SortedList<int, int> sortedlist;
        private readonly SortedDictionary<int, int> sorteddict;
        private readonly ArrayList arrayList;

        //! Constructor
        public CollectionBenchmark()
        {
            array = Enumerable.Range(0, Len).ToArray();
            list = Enumerable.Range(0, Len).ToList();
            hashset = Enumerable.Range(0, Len).ToHashSet();
            sortedset = new SortedSet<int>(Enumerable.Range(0, Len));
            enumrable = Enumerable.Range(0, Len);
            dict = Enumerable.Range(0, Len).ToDictionary(key => key, value => value);
            queue = new Queue<int>(Enumerable.Range(0, Len));
            stack = new Stack<int>(Enumerable.Range(0, Len));
            linklist = new LinkedList<int>(Enumerable.Range(0, Len));
            sortedlist = new SortedList<int, int>(Enumerable.Range(0, Len).ToDictionary(key => key, value => value));
            sorteddict = new SortedDictionary<int, int>(Enumerable.Range(0, Len).ToDictionary(key => key, value => value));
            arrayList = new ArrayList(Enumerable.Range(0, Len).Cast<object>().ToArray());
        }

        //todo Enumbrable
        [Benchmark]
        public int EnumItrat()
        {
            var total = 0;
            foreach (var item in enumrable)
            {
                total += item;
            }
            return total;
        }
        //todo Hashset
        [Benchmark]
        public int hashItrat()
        {
            var total = 0;
            foreach (var item in hashset)
            {
                total += item;
            }
            return total;
        }
        //todo array
        [Benchmark]
        public int arrayItrat()
        {
            var total = 0;
            foreach (var item in array)
            {
                total += item;
            }
            return total;
        }
        //todo list
        [Benchmark]
        public int listItrat()
        {
            var total = 0;
            foreach (var item in list)
            {
                total += item;
            }
            return total;
        }
        //todo sortedlist
        [Benchmark]
        public int sortlistItrat()
        {
            var total = 0;
            foreach (var item in sortedlist)
            {
                total += item.Value;
            }
            return total;
        }
        //todo sortedset
        [Benchmark]
        public int sortsetItrat()
        {
            var total = 0;
            foreach (var item in sortedset)
            {
                total += item;
            }
            return total;
        }
        //todo dict
        [Benchmark]
        public int dictItrat()
        {
            var total = 0;
            foreach (var item in dict)
            {
                total += item.Key;
            }
            return total;
        }
        //todo arraylist
        [Benchmark]
        public int arrayListItrat()
        {
            var total = 0;
            foreach (var item in arrayList)
            {
                total += (int)item;
            }
            return total;
        }

        //todo linklist
        [Benchmark]
        public int linklistItrat()
        {
            var total = 0;
            foreach (var item in linklist)
            {
                total += item;
            }
            return total;
        }

        //todo queue
        [Benchmark]
        public int queueItrat()
        {
            var total = 0;
            foreach (var item in queue)
            {
                total += item;
            }
            return total;
        }
        //todo stack
        [Benchmark]
        public int stackItrat()
        {
            var total = 0;
            foreach (var item in stack)
            {
                total += item;
            }
            return total;
        }
        //todo sorteddict
        [Benchmark]
        public int sorteddictItrat()
        {
            var total = 0;
            foreach (var item in sorteddict)
            {
                total += item.Value;
            }
            return total;
        }

    }
}