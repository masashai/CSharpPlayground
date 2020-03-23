using System;
using System.Globalization;

namespace CSharpPlayground.Lib
{
    public static class Extensions
    {
        public static int LengthInTextElements(this String str)
        {
            var stringInfo = new StringInfo(str);
            return stringInfo.LengthInTextElements;
        }

        public static String SubstringByTextElements(this String str, int index)
        {
            var stringInfo = new StringInfo(str);
            return stringInfo.SubstringByTextElements(index);
        }

        public static String SubstringByTextElements(this String str, int index, int length)
        {
            var stringInfo = new StringInfo(str);
            return stringInfo.SubstringByTextElements(index, length);
        }
    }
}
