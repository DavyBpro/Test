using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        static void WBash(ref string s)
        {

        }
        static void Main(string[] args)
        {
            string s = "Hello World !";
            char[] chartab = s.ToCharArray();
            char[] newtab = new char[chartab.Length - 1];
            int j = 0;
            for (int i = 0; i < chartab.Length; i++)
            {
                if (chartab[i] == 'W')
                    continue;
                newtab[j] = chartab[i];
                j++;
            }
            s = new string(newtab);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
