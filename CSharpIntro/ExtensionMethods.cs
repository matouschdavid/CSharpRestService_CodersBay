using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro
{
    //must be static class
    public static class ExtensionMethods
    {
        //static classes can only have static variables and methods
        //first param has a this in front to indicate that this is an extension of this type
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
