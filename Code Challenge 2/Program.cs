using System;

namespace Code_Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(char.ToUpper(str[0])+ str.Substring(1)); 
            string str = "jagaban of bornu";
            var words = str.Split(" ");
            Array.ForEach(words, Console.WriteLine);
        }
    }
}
