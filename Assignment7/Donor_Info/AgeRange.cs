using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public enum AgeRange
    {
        /// <summary>
        /// enum (nouns) used to indicate (biological) age ranges
        /// integers shall be adjusted based on cooresponsing research convention
        /// Or relevant definition
        /// </summary>
        
        Baby, // = 7
        Child, // = 9
        Preteen, // = 12
        Teenager, // = 19
        YoungAdult, // = 25
        Adult, // = 65
        Retiree, // = 80
        Old // = Int32.MaxValue
    }
}
