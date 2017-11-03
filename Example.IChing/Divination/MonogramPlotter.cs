using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.IChing.Divination
{
    public class MonogramPlotter
    {
        const string BROKEN = "- -";
        const string UNBROKEN = "---";

        private int _score;

        public MonogramPlotter(int score)
        {
            _score = score;
        }

        public override string ToString()
        {
            string thePresent = Present();

            switch (_score)
            {
                case 9:
                case 6:
                    return $".{thePresent}";
                default:
                    return thePresent;
            }
        }

        public string Present()
        {
            switch (_score)
            {
                case 9:
                case 7:
                    return UNBROKEN;
                default:
                    return BROKEN;
            }
        }


        public string Future()
        {
            switch (_score)
            {
                case 9:
                    return BROKEN;
                case 6:
                    return UNBROKEN;
                default:
                    return Present();
            }
        }
    }
}
