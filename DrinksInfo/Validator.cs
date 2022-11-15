using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksInfo
{
    internal class Validator
    {
        internal static bool IsStringValid(string? category)
        {
            if (String.IsNullOrEmpty(category))
            {
                return false;
            }

            foreach (char c in category)
            {
                if (!Char.IsLetter(c) && c != '/' && c != ' ') { 
                return false;}
            }
            return true;
        }
    }
}
