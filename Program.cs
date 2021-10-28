using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalinDromeProgram1
{
    class Program
    {
          static void Main(string[] args)
            {
                PalinDromeNumber();
            }
            static void PalinDromeNumber()
            {
                Console.WriteLine("ENTER THE STRING VALUE TO CHECK WHETHER IT IS PALINDROME OR NOT");
                string value = Console.ReadLine();
                string temp = value;
                string rev = null;
                char[] ch = value.ToCharArray();
                for (int i = value.Length - 1; i >= 0; i--)
                {
                    rev = rev + ch[i];
                }
                Console.WriteLine(rev);
                if (temp.Equals(rev))
                {
                    Console.WriteLine(temp + " is a palendrum value");

                }
                else
                    Console.WriteLine(temp + " is  not a palendrum value");

            }
        }
    }

