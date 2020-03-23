using System;
using System.Globalization;

namespace CSharpPlayground.Lib
{
    public static class Extensions
    {
        /// <summary>
        /// 4byte文字でも正しく文字カウントしてくれる
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int LengthInTextElements(this String str)
        {
            var stringInfo = new StringInfo(str);
            return stringInfo.LengthInTextElements;
        }

        /// <summary>
        /// 4byte文字でも正しくSubstringしてくれる
        /// </summary>
        /// <param name="str"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static String SubstringByTextElements(this String str, int index)
        {
            var stringInfo = new StringInfo(str);
            return stringInfo.SubstringByTextElements(index);
        }

        /// <summary>
        /// 4byte文字でも正しくSubstringしてくれる
        /// </summary>
        /// <param name="str"></param>
        /// <param name="index"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static String SubstringByTextElements(this String str, int index, int length)
        {
            var stringInfo = new StringInfo(str);
            return stringInfo.SubstringByTextElements(index, length);
        }
    }
}
