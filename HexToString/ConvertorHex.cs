using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace HexToString
{
public static class ConvertorHex
    {
        public static string BytesToHex(Byte [] bytes)
        {
            return string.Concat(bytes.Select(y => y.ToString("x2")).ToArray());
        }

        public static string StringToHex(string text, Encoding encoding)
        {
            return BytesToHex(encoding.GetBytes(text));
        }

        public static string StringToHex(string text)
        {
            return StringToHex(text, Encoding.Default);
        }

        public static byte[] HexToBytes(string hexTex)
        {
            return String.IsNullOrEmpty(hexTex) ?null :Enumerable.Range(0, hexTex.Length - 1).Where(y => (y & 1) == 0).Select(y => Byte.Parse(hexTex[y] + hexTex[y + 1].ToString(), NumberStyles.HexNumber)).ToArray();
        }

        public static string HexToString(string hexTex, Encoding encoding)
        {
            return String.IsNullOrEmpty(hexTex) ? String.Empty : encoding.GetString(HexToBytes(hexTex));
        }

        public static string HexToString(string hexTex)
        {
            return HexToString(hexTex, Encoding.Default);
        }
    }
}
