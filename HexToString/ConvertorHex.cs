using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace HexToString
{
    public class ConvertorHex
    {
        public string StringToHex(string text, Encoding encoding)
        {
            return String.Join(String.Empty, encoding.GetBytes(text).Select(y => y.ToString("x")));
        }

        public string StringToHex(string text)
        {
            return StringToHex(text, Encoding.Default);
        }

        public string HexToString(string hexTex, Encoding encoding)
        {
            return String.IsNullOrEmpty(hexTex)? String.Empty: encoding.GetString(Enumerable.Range(0, hexTex.Length - 1).Where(y => (y & 1) == 0).Select(y => Byte.Parse(hexTex[y] + hexTex[y + 1].ToString(), NumberStyles.HexNumber)).ToArray());
        }

        public string HexToString(string hexTex)
        {
            return HexToString(hexTex, Encoding.Default);
        }
    }
}