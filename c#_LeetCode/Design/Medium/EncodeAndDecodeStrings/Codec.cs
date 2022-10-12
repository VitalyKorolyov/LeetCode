using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Design.Medium.EncodeAndDecodeStrings
{
    //https://leetcode.com/problems/encode-and-decode-strings/
    public class Codec
    {
        private string IntToString(int value)
        {
            var str = value.ToString();

            if (str.Length < 4)
            {
                var strB = new StringBuilder(4);

                for (int i = 0; i < 4 - str.Length; i++)
                    strB.Append("0");

                strB.Append(str);

                return strB.ToString();
            }
            return str;
        }

        private int StringToInt(string value)
        {
            return Convert.ToInt32(value);
        }

        // Encodes a list of strings to a single string.
        public string encode(IList<string> strs)
        {
            var res = new StringBuilder();

            foreach (var str in strs)
            {
                var length = str.Length;
                res.Append(IntToString(length));
                res.Append(str);
            }

            return res.ToString();
        }

        // Decodes a single string to a list of strings.
        public IList<string> decode(string s)
        {
            int i = 0, n = s.Length;
            List<string> output = new();

            while (i < n)
            {
                int length = StringToInt(s.Substring(i, 4));
                i += 4;
                output.Add(s.Substring(i, length));
                i += length;
            }

            return output;
        }
    }
}
