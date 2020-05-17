using System;
using System.Collections.Generic;
using System.Text;

namespace FormatStrings
{
    public class RemoveReplace
    {
        private static string getXML(string input, string key)
        {
            int start = input.IndexOf($"<{key}>") + key.Length + 2;
            int end = input.IndexOf($"</{key}>");
            return input.Substring(start, end - start);
        }
        public static void execute()
        {
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = getXML(input, "span");
            string output = input.Replace("trade", "reg");

            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
