using System;

namespace WebApiHacoupian.Extention
{
    public static class Utility
    {
        public static double RoundMoney(double price)
        {
            return Math.Round(price / 1000) * 1000;
        }
    }
}
