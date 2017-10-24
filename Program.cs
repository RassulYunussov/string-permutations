using System;
using System.Collections.Generic;
using System.IO;

namespace lab
{
    class Program
    {
        
        public static IEnumerable<string> permutations(string src)
        {
            List<string> output= new List<string>(fact(src.Length));
            for(int i = 0;i<src.Length;i++)
            {
               string prefix = src.Substring(i,1);
               string left = src.Substring(0,i);
               string right = (i==src.Length-1)?"":src.Substring(i+1,src.Length-(i+1));
               permutations(prefix,left+right);
            }
            return output;
            int fact(int x)=>x==0?1:fact(x-1)*x;
            void permutations(string prefix,string input)
            {
                if(input.Length==0)
                    output.Add(prefix);
                else
                {
                    for(int i = 0;i<input.Length;i++)
                    {
                        string pref = prefix+input.Substring(i,1);
                        string left = input.Substring(0,i);
                        string right = input.Substring(i+1,input.Length-(i+1));
                        permutations(pref,left+right);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            var res = permutations("1234");
            foreach (var s in res)
                System.Console.WriteLine(s);
        }
    }
}
