
using Example.IChing.Divination;
using System;
using System.Collections.Generic;

using Example.IChing.Utils;

namespace Example.IChing.Divination
{
    
    public class Caster
    {
        
        public List<int> Cast()
        {
            return CastSixLines();
        }


        private List<int> CastSixLines()
        {
            List<int> Scores = new List<int>(6);
            6.Times(() => Scores.Add(Scorer.Score(CastLine())));
            return Scores;
        }

        private List<Toss> CastLine()
        {
            return TossThreeCoins();
        }


        private List<Toss> TossThreeCoins()
        {
            List<Toss> Tosses = new List<Toss>(3);
            3.Times(() => Tosses.Add(TossCoin()));
            return Tosses;
        }


        private Toss TossCoin()
        {
            return Toss.Heads; // TODO Make this random
        }
    }
}






