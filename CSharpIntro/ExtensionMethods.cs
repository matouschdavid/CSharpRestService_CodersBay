using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro
{
    public static class ExtensionMethods
    {
        public static string TakeOften(this char character, int n)
        {
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s += character;
            }
            return s;
        }
    }
}
