using System.Numerics;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdvanceC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Qu1
            //  Q1: What is a generic class? Why use generics?
            //A generic class is a class that can work with different data types without rewriting the class for each type.
            //Why use generics?
            //Generics are useful because they:
            // Provide type safety — incorrect types can be detected at compile time.
            // Reduce code duplication — one class or method can work with many data types.
            // Avoid unnecessary type casting — retrieved values already have the correct type.
            // Make code reusable and easier to maintain.

            #endregion

            #region QU2
            //Q2: Write a generic class Container<T> with Add and Get methods.
           // Container<int> c1 = new Container<int>();
            //c1.Add(10);
            //Console.WriteLine(c1.Get());
            #endregion
        }
    }
}
