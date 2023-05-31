using System;
using System.Runtime.Serialization;

namespace Full_GRASP_And_SOLID
{
    public class Check
    {
        public static void Precondition(bool condition, string message)
        {
            if (!condition)
            {
                throw new PreconditionException(message);
            }
        }

        public static void Precondition(bool condition)
        {
            Precondition(condition, "Precondición insatisfecha");
        }

        public static void Postcondition(bool condition, string message) 
        {

        }
        public static void Postcondition(bool condition) 
        {

        }
        public static void Invariant(bool condition, string message) 
        {

        }
        public static void Invariant(bool condition ) 
        {
            
        }
    }
}
