namespace Birds{

public interface Bird1
    {
        /// <summary>
        /// Method to make the bird fly
        /// </summary>
        void Fly();
        /// <summary>
        /// Method to make the bird swim
        /// </summary>
        void Swim();
        /// <summary>
        /// Method to make the bird walk
        /// </summary>
          void Walk();

    }
public interface Bird2
    {
        /// <summary>
        /// Method to make the bird sing
        /// </summary>
        void Sing();
        /// <summary>
        /// Method to make the bird dance
        /// </summary>
        void Dance();
        /// <summary>
        /// Method to make the bird walk
        /// </summary>
        void Walk();

    }

public class Hybrid_Bird : Bird1, Bird2
    {
        /// <summary>
        /// Implementation of Fly method from Bird1 interface
        /// </summary>
        public void Fly()
        {
            Console.WriteLine(" Bird is Flying");
        }

        /// <summary>
        /// Implementation of Swim method from Bird1 interface
        /// </summary>

        public void Swim()
        {
            Console.WriteLine(" Bird is Swimming");
        }
        /// <summary>
        /// Implementation of Sing method from Bird2 interface
        /// </summary>

        public void Sing()
        {
            Console.WriteLine(" Bird is Singing");
        }
    /// <summary>
    /// Implementation of Dance method from Bird2 interface
    /// </summary>
        public void Dance()
        {
            Console.WriteLine(" Bird is Dancing");
        }

        /// <summary>
        /// Explicit implementation of Walk method to resolve ambiguity between Bird1 and Bird2 interfaces
        /// </summary>
          void Bird1.Walk()
        {
            Console.WriteLine(" Bird is Walking bcz of Bird1");
        }

        /// <summary>
        /// Explicit implementation of Walk method to resolve ambiguity between Bird1 and Bird2 interfaces
        /// </summary>
        void Bird2.Walk()
        {
            Console.WriteLine(" Bird is Walking bcz of Bird2");
        }
    }
}
