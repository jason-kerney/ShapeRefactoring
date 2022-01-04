using System;
using System.Collections.Generic;

namespace Shape.Lib
{
    public class Checker<T> : IEqualityComparer<T>
    {
        private readonly Func<T, T, bool> chck;
        private readonly Func<T, int> hscd;

        public Checker(Func<T, T, bool> chck, Func<T, int> hscd)
        {
            this.chck = chck;
            this.hscd = hscd;
        }

        public bool Equals(T x, T y)
        {
            return chck(x, y);
        }

        public int GetHashCode(T obj)
        {
            return this.hscd(obj);
        }
    }
}