using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_For_Translation
{
    public class Tool
    {
        private const double cmtoinch = 0.393701;
        public static bool check_input(string input)
        {
            int cnt = 0;
            int location = input.Length;
            if (input.Length == 0) return false;
            if (input[0] == ',' || input[input.Length-1] ==',') return false;
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if ((ch < '0' || ch > '9') && ch!='.' && ch != ',') { return false; }
                if (ch == '.') { cnt++; location = i; }
            }
            if (cnt > 1) return false;
            for(int i = location; i < input.Length; i++)
                if (input[i] == ',') return false;
            return true;
        }
        public static string ToInch(string data)
        {
            return (double.Parse(data) * cmtoinch).ToString("N3");
        }
        public static string ToCm(string data)
        {
            return (double.Parse(data) / cmtoinch).ToString("N3");
        }

    }
}
