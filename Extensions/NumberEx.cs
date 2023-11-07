using System.Globalization;

namespace AleVerDes.UnityUtils
{
    public static class NumberEx
    {
        private static NumberFormatInfo _numberFormatInfo;

        private static NumberFormatInfo GetNumberFormatInfo()
        {
            if (_numberFormatInfo == null)
            {
                _numberFormatInfo = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
                _numberFormatInfo.NumberGroupSeparator = " ";
            }

            return _numberFormatInfo;
        }

        public static string ToNumberFormat(this int number) 
        {
            return number.ToString("#,0", GetNumberFormatInfo());
        }
    }
}