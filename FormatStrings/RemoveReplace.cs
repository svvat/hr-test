using System;
using System.Collections.Generic;
using System.Text;

namespace FormatStrings
{
    // task 
    /// <summary>
    /// 1 Set the quantity variable to the value you extract from between the <span> and </span> tags.
    /// 2 Set the output variable to the value of input, then remove the<div> and</div> tags.
    /// 3 Replace the HTML character &trade; with &reg; in the output variable.
    /// 
    /// </summary>
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
            string output = input
                .Replace("trade", "reg")
                .Replace("<div>", "")
                .Replace("</div>", "");

            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
