// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DiningPhilosopher.cs" company="">
//   
// </copyright>
// <summary>
//   The dining philosopher.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Threading
{
    using System;
    using System.Threading;

    /// <summary>The dining philosopher.</summary>
    internal class DiningPhilosopher
    {
        /// <summary>The chopstick.</summary>
        public class Chopstick
        {
            /// <summary>The lock.</summary>
            private readonly object lockObject = new object();

            /// <summary>Initializes a new instance of the <see cref="Chopstick"/> class.</summary>
            /// <param name="identifier">The identifier.</param>
            public Chopstick(int identifier)
            {
                this.Identifier = identifier;
            }

            /// <summary>Gets or sets the identifier.</summary>
            public int Identifier { get; set; }

            /// <summary>The pickup.</summary>
            /// <returns>The <see cref="bool"/>.</returns>
            public bool Pickup()
            {
                var o = this.lockObject;
                return o != null && Monitor.TryEnter(o);
            }

            /// <summary>The put down.</summary>
            /// <returns>The <see cref="bool"/>.</returns>
            /// <exception cref="ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception>
            /// <exception cref="ThreadInterruptedException">The thread that invokes Wait is later interrupted from the waiting state. This happens when another thread calls this thread's <see cref="M:System.Threading.Thread.Interrupt" /> method. </exception>
            /// <exception cref="SynchronizationLockException">The calling thread does not own the lock for the specified object. </exception>
            public bool PutDown()
            {
                var o = this.lockObject;
                return o != null && Monitor.Wait(o);
            }
        }

        /// <summary>The philosopher.</summary>
        public class Philosopher
        {
            /// <summary>The identifier.</summary>
            private int identifier;

            /// <summary>The left.</summary>
            private Chopstick left;

            /// <summary>The right.</summary>
            private Chopstick right;

            /// <summary>Initializes a new instance of the <see cref="Philosopher"/> class.</summary>
            /// <param name="identifier">The identifier.</param>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            public Philosopher(int identifier, Chopstick left, Chopstick right)
            {
                this.identifier = identifier;
                this.left = left;
                this.right = right;
            }
        }
    }
}