using System;

namespace WebApiHacoupian
{
    public static class EpouchConvertor
    {
        public static DateTime EpouchToDateTime(double epouch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epouch);
        }
    }
}