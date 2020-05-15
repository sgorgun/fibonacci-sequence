using System;
using System.Numerics;

namespace FibonacciTask
{
    /// <summary>
    /// Generator for Fibonacci sequence.
    /// </summary>
    /// <seealso cref="https://en.wikipedia.org/wiki/Fibonacci_number"/>
    public class FibonacciSequence
    {
        //TODO: Add necessary code and/or remove this comment.

        /// <summary>
        /// Initializes a new instance of the <see cref="FibonacciSequence"/> class.
        /// </summary>
        /// <param name="count">Count of elements in Fibonacci sequence.</param>
        /// <exception cref="ArgumentException">Thrown if count of elements less than two.</exception>
        public FibonacciSequence(int count)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Current element in Fibonacci sequence.
        /// </summary>
        /// <value>
        /// Value of current element in Fibonacci sequence.
        /// </value>
        public BigInteger Current
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Moves to the next element in the sequence.
        /// </summary>
        /// <returns>
        /// True if there are elements in the sequence, false otherwise.
        /// </returns>
        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Resets the sequence to the beginning.
        /// </summary>
        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}