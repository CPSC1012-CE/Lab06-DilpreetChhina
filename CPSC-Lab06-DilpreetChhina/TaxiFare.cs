using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC_Lab06_DilpreetChhina
{
    internal class TaxiFare
    {
        public int _minutes { get; set; }
        public int _kmTravelled { get; set; }

        public double Fair { get; set; }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value < 10)
                {
                    throw new Exception("Invalid trip minutes, Minimum minutes are 10");
                }
                _minutes = value;
            }
        }
        public int KmTravelled
        {
            get { return _kmTravelled; }
            set
            {
                if (value < 2)
                {
                    throw new Exception("Invalid trip kilimeters, Minimum kilometers are 2");
                }
                _kmTravelled = value;
            }
        }
        public TaxiFare(int minutes, int km)
        {
            Minutes = minutes;
            KmTravelled = km;
            CalculateFair(minutes, km);

        }

        public double CalculateFair(int minutes, int km)
        {
            Fair = (minutes * 0.25 + km * 1.25) * 1.10;
            return Fair;
        }


    }
}
