using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Reduced_String
{
    class Program
    {
        /*
         Problem: 
         Steve has a string, , consisting of lowercase English alphabetic letters.
         In one operation, he can delete any pair of adjacent letters with same value.
         For example, string "aabcc" would become either "aab" or "bcc" after operation.
         Steve wants to reduce as much as possible. 
         To do this, he will repeat the above operation as many times as it can be performed. 
         Help Steve out by finding and printing 's non-reducible form!
        */
        static void Main(string[] args)
        {
            string s = "baab"; //Our initial string

            //Instantiate a StringBuilder to conduct string operations
            StringBuilder sb = new StringBuilder(s);
            int idx = 0; 
            while(idx < sb.Length-1)
            {
                if (sb[idx] == sb[idx + 1])
                {
                    sb.Remove(idx, 2);
                    if (idx > 0)
                        idx--;
                }
                else idx++;
            }
            if (sb.Length > 0)
                Console.WriteLine(sb.ToString());
            else Console.WriteLine("Empty String");
            Console.ReadKey();
        }
    }
}
