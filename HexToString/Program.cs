using System;

namespace HexToString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var convertorHex = new ConvertorHex();
            Console.WriteLine(convertorHex.HexToString(convertorHex.StringToHex("abcdefgh")));
        }
    }
}