using System;

namespace Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter num 1");
            int num1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter num 2");
            int num2=int.Parse(Console.ReadLine());
            System.Console.WriteLine(subtraction(num1,num2));
        }
        public static int subtraction(int num1, int num2)
        {
            int length=0;
            bool prime= true;
                while (prime)
                {
                     for (int i = 0; num1>0&&num2>0; i++)
                {
                    if (num1>=num2)
                    {
                        num1=num1-num2;
                    }
                    else
                    {
                        num2=num2-num1;
                    }
                     length++;
                    if (num1==0||num2==0)
                    {
                        return length; 
                    }
                    
                    
                }
                }
                return length;
        }
    }
}
