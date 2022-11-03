using System;
namespace ConvertToHex
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertToHex("hello world")); //➞ "68 65 6c 6c 6f 20 77 6f 72 6c 64"

            Console.WriteLine(ConvertToHex("Big Boi")); //➞ "42 69 67 20 42 6f 69"

            Console.WriteLine(ConvertToHex("Marty Poppinson")); //➞ "4d 61 72 74 79 20 50 6f 70 70 69 6e 73 6f 6e"
        }
        public static string ConvertToHex(string str)
        {
            byte[] lol = System.Text.Encoding.ASCII.GetBytes(str);
            string result = BitConverter.ToString(lol, 0, str.Length).Replace("-", " ").ToLower();
            return result;
        }
    }
}
 