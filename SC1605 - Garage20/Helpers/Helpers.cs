using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC1605___Garage20.Helpers
{
    public static class Helpers
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source != null && toCheck != null && source.IndexOf(toCheck, comp) >= 0;
        }
    }
}