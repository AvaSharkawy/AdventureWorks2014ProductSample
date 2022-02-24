using System;

namespace AnventureWorks2014Sample
{
    public static class Extensions
    {
        #region String

        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static int AsIntSafe(this string value)
        {
            if (value.IsNullOrEmpty())
                return 0;

            return Convert.ToInt32(value);
        }

        public static decimal AsDecimalSafe(this string value)
        {
            if (value.Trim().IsNullOrEmpty())
                return 0M;

            return Convert.ToDecimal(value);
        }

        #endregion

        #region Objects

        public static int AsIntSafe(this object value)
        {
            if (value?.ToString().IsNullOrEmpty() ?? true)
                return 0;

            return Convert.ToInt32(value);
        }

        public static decimal AsDecimalSafe(this object value)
        {
            if (value?.ToString().IsNullOrEmpty() ?? true)
                return 0M;

            return Convert.ToDecimal(value);
        }

        #endregion
    }
}
