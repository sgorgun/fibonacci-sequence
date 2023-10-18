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
        private readonly int _count;
        private BigInteger _current = 1;
        private BigInteger _previous;
        private int _index ;
         
        /// <summary>
        /// Initializes a new instance of the <see cref="FibonacciSequence"/> class.
        /// </summary>
        /// <param name="count">Count of elements in Fibonacci sequence.</param>
        /// <exception cref="ArgumentException">Thrown if count of elements less than one.</exception>
        public FibonacciSequence(int count)
        {
            this._count = count;
            if (count < 1)
            {
                throw new ArgumentException("Count of elements less than one.");
            }
        }

        /// <summary>
        /// Current element in Fibonacci sequence.
        /// </summary>
        /// <value>
        /// Value of current element in Fibonacci sequence.
        /// </value>
        public BigInteger Current => _current;

        /// <summary>
        /// Moves to the next element in the sequence.
        /// </summary>
        /// <returns>
        /// True if there are elements in the sequence, false otherwise.
        /// </returns>
        public bool MoveNext()
        {
            if (_index == _count)
            {
                return false;
            }
                        
            var temp = _current;
            _current = _index++ == 0 ? _previous : _current +_previous;
            _previous = temp;
            return true;
        }

        /// <summary>
        /// Resets the sequence to the beginning.
        /// </summary>
        public void Reset()
        {
            _current = 1;
            _previous = 0;
            _index = 0;
        }
    }
}