using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IO_2A_Testy
{
    public class Calculator
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public string Reverse(string s)
        {
            int n = s.Length;
            char[] chars = new char[n];
            chars = s.ToCharArray();
            int m;

            if (n % 2 == 0)
            {
                m = n / 2;
            }
            else m = n / 2 + 1;

            for(int i  = 0; i < m; i++)
            {
                char helper = chars[i];
                chars[i] = chars[n-1-i];
                chars[n-1-i] = helper;
            }

            string result = new string(chars);
            return result;
        }
    }
}
