using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ReverseStringService : IReverseString
    {
        public string ReverseString(string value)
        {
            string[] stringArray = value.Split(" ");
            string output = "";

            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                output += stringArray[i] + " ";

            }
            return output;
        }
    }
}
