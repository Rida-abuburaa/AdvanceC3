using System.Data;
using System.Numerics;
using System.Reflection.Metadata;
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

            #region QU3
            //Q3:What are multiple type parameters? Write Pair<TKey, TValue >.
            //Multiple type parameters means a generic class can use more than one generic type.

            #endregion

            #region Qu4
            //Q4: What is a generic method? Write Swap<T> method.
            // A generic method is a method that can work with different data types using a type parameter such as T.

            #endregion

            #region Qu5
            //Console.WriteLine(methods.FindMax(10, 20));

            #endregion


            #region Qu6
            //Q6: What is a generic interface? Write IRepository<T>. 
            //A generic interface is an interface that uses a type parameter such as T. It allows the same interface to work with different data types.

            #endregion

            #region Qu7
            //Q7: What is the 'struct' constraint? Write an example. 
            //The struct constraint means that the generic type T must be a value type.
            //ex:
            /*static void Show<T>(T value) where T : struct
            {
                Console.WriteLine(value);
            }

            static void Main()
            {
                Show<int>(10);
                Show<double>(5.5);
            }*/
            #endregion

            #region Qu8
            //Q8: What is the class constraint?
            //The class constraint means that T must be a reference type(class).
            /*
             static void Show<T>(T value) where T : class
            {
                   Console.WriteLine(value);
             }

             static void Main()
              {
                  Show<string>("Hello");
             } 
             */
            #endregion

            #region Qu 9-12
            //Q9: new() constraint
            // The new() constraint means T must have a public parameterless constructor.
            //  where T : new ()
            //  Q10: Interface constraint
            //An interface constraint means T must implement a specific interface.
            //where T : IInterface
            //Q11: Base class constraint
            //A base class constraint means T must inherit from a specific base class.
            //where T : BaseClass
            //Q12: Multiple constraints
            //Multiple constraints are written after where T : and separated by commas.
            //where T : BaseClass, IInterface, new ()


        }
    }
    }
