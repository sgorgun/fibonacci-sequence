using System;
using System.Numerics;
using NUnit.Framework;

namespace FibonacciTask.Tests
{
    [TestFixture]
    public class FibonacciSequenceTests
    {
        [TestCase(3, new long[] {0, 1, 1})]
        [TestCase(13, new long[] {0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144})]
        [TestCase(23, new long[]
        {
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711
        })]
        [TestCase(41, new long[]
        {
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711,
            28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040, 1346269, 2178309, 3524578, 5702887,
            9227465, 14930352, 24157817, 39088169, 63245986, 102334155
        })]
        [TestCase(46, new long[]
        {
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711,
            28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040, 1346269, 2178309, 3524578, 5702887,
            9227465, 14930352, 24157817, 39088169, 63245986, 102334155, 165580141, 267914296, 433494437, 701408733,
            1134903170
        })]
        [TestCase(80, new[]
        {
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711,
            28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040, 1346269, 2178309, 3524578, 5702887,
            9227465, 14930352, 24157817, 39088169, 63245986, 102334155, 165580141, 267914296, 433494437, 701408733,
            1134903170, 1836311903, 2971215073, 4807526976, 7778742049, 12586269025, 20365011074, 32951280099,
            53316291173, 86267571272, 139583862445, 225851433717, 365435296162, 591286729879, 956722026041,
            1548008755920, 2504730781961, 4052739537881, 6557470319842, 10610209857723, 17167680177565,
            27777890035288, 44945570212853, 72723460248141, 117669030460994, 190392490709135, 308061521170129,
            498454011879264, 806515533049393, 1304969544928657, 2111485077978050, 3416454622906707,
            5527939700884757, 8944394323791464, 14472334024676221
        })]
        public void FibonacciSequence_MoveNextAndCurrentTests(int count, long[] expected)
        {
            var sequence = new FibonacciSequence(count);
            int i = 0;
            while (sequence.MoveNext())
            {
                Assert.AreEqual(new BigInteger(expected[i++]), sequence.Current);
            }
        }

        [TestCase(13, 10, new long[] {0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144})]
        [TestCase(23, 15, new long[]
        {
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711
        })]
        [TestCase(41, 34, new long[]
        {
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711,
            28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040, 1346269, 2178309, 3524578, 5702887,
            9227465, 14930352, 24157817, 39088169, 63245986, 102334155
        })]
        public void FibonacciSequence_ResetTests(int count, int k, long[] expected)
        {
            var sequence = new FibonacciSequence(count);

            while (sequence.MoveNext())
            {
            }

            sequence.Reset();

            for (int i = 0; i < k; i++)
            {
                sequence.MoveNext();
            }

            Assert.AreEqual(new BigInteger(expected[k - 1]), sequence.Current);
        }

        [TestCase(1_000)]
        [TestCase(1_000_000)]
        public void FibonacciSequence_LongSequenceTests(int count)
        {
            var sequence = new FibonacciSequence(count);
            int k = 0;

            while (sequence.MoveNext())
            {
                k++;
            }

            Assert.IsTrue(k == count);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-234)]
        public void FibonacciSequence_CountOfElementsIsLessThanTwo_ThrowArgumentException(int count)
            => Assert.Throws<ArgumentException>(() =>
                {
                    var fibonacciSequence = new FibonacciSequence(count);
                },
                message: "Count of elements of sequence cannot be less than 2.");
    }
}