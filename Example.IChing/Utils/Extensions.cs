using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.IChing.Utils
{
    /// <summary>
    /// Useful extension methods in the style of Ruby
    /// </summary>
    public static class Extensions
    {


        // .Sample to enums like Ruby
        //public static object SampleAnyEnum_DoesNotWork<T>(this T e) 
        //{
        //    if (false == typeof(T).IsEnum)
        //    {
        //        throw new ArgumentException("n must be an enum type", nameof(e));
        //    }
            
        //    Array values = Enum.GetValues(typeof(T));
        //    Random random = new Random();
        //    T randomE = (T)values.GetValue(random.Next(values.Length));

        //    return randomE;
        //}


        // .Sample to enums like Ruby
        //public static object Sample<Toss>(this Type Toss)
        //{

        //    Array values = Enum.GetValues(typeof(Toss));
        //    Random random = new Random();
        //    Toss randomToss = (T)values.GetValue(random.Next(values.Length));

        //    return randomE;
        //}
        // Google extension static method on class



        // Adding Ruby style "x.Times" to C#:
        // https://stackoverflow.com/a/3932432
        // by the legendary Jon Skeet (from Reading in case you don't know!)
        public static void Times(this int count, Action action)
        {
            for (int i = 0; i < count; i++)
            {
                action();
            }
        }
    }
}
