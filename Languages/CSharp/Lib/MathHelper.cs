using System;

namespace Shape.Lib
{
    public static class MathHelper
    {
        internal static Func<int?, dynamic> Gs(int s)
        {
            return Utils.Draconifors(s);
        }

        public static Func<int?, dynamic> Gz()
        {
            return Utils.Kneazles();
        }

        internal static dynamic no = null;
    }
}