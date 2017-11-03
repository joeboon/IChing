using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.IChing.Divination
{
    public static class Scorer
    {
        public static int Score(List<Toss> Tosses)
        {
            return SumValues(Tosses);
        }

        static private int SumValues(List<Toss> Tosses)
        {
            return Tosses.Sum(t => ConvertTossToValue(t));
        }

        static private int ConvertTossToValue(Toss toss)
        {
            return (int)toss;
        }
    }

}


