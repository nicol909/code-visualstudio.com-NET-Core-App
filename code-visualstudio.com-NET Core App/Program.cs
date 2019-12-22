using System;
using System.Runtime;

namespace code_visualstudio.com_NET_Core_App
{
    class Program
    {
        private const string Value = "String Value";

        static void Main(string[] args)
        {
            Program.WriteLine(Value);
            string v = Console.ReadLine();
            string Value = v;
        }

        private static void WriteLine(string value)
        {
            throw new NotImplementedException();
        }
    }
}
