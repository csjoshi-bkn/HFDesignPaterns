using One;
using System;

namespace ChapterOne
{
  public abstract class Duck
    {
        private IFlyBehavior FlyBehavior;
        private IQuackBehavior QuackBehavior;

        public event EventHandler Kill;
        
        /// <summary>
        /// Destroy the Duck Object.
        /// </summary>
        ~Duck()
        {
            this.Kill(this, EventArgs.Empty);
        }

        /// <summary>
        /// Display duck as implemented in Concrete class
        /// </summary>
        public abstract void Display();

        /// <summary>
        /// Set the Fly behavior of duck at runtime
        /// </summary>
        /// <param name="fb">Flying behavior of Duck.</param>
        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            FlyBehavior = flyBehavior;
        }

        /// <summary>
        /// Set the Quack behavior of duck at runtime
        /// </summary>
        /// <param name="qb">Quack behavior of Duck.</param>
        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            QuackBehavior = quackBehavior;
        }

        /// <summary>
        /// Perform Quack as set by Concrete class
        /// </summary>
        public void PerformQuack()
        {
            if (QuackBehavior != null)
                QuackBehavior.Quack();
            else
                Console.WriteLine(Resources.StrExPerformQuack);
        }

        /// <summary>
        /// Perform Fly as set by Concrete class
        /// </summary>
        public void PerformFly()
        {
            if (FlyBehavior != null)
                FlyBehavior.Fly();
            else
                Console.WriteLine(Resources.StrExPerformFly);
        }

        /// <summary>
        /// Command Duck to Swim.
        /// </summary>
        internal static void Swim()
        {
            Console.WriteLine(Resources.StrSwim);
        }
    }
}
