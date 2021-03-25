using System;
using System.Collections.Generic;
using System.Linq;

namespace sorts
{
    public class defaultList
    {
        private static Random rand = new Random();
        protected static readonly IList<int> List =  Enumerable.Range(0, 20 + 1).Select(i => rand.Next(50)).ToList();
    }
}
