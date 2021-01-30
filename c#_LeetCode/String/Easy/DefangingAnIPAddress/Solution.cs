using System;
using System.Text;

namespace LeetCode.String.Easy.DefangingAnIPAddress
{
    //https://leetcode.com/problems/defanging-an-ip-address/
    public class FirstSolution
    {
        public string DefangIPaddr(string address)
        {
            var addressDefangBuilder = new StringBuilder(address.Length + 6);

            foreach (var addressPart in address)
            {
                if (addressPart != '.')
                {
                    addressDefangBuilder.Append(addressPart);
                }
                else
                {
                    addressDefangBuilder.Append('[');
                    addressDefangBuilder.Append('.');
                    addressDefangBuilder.Append(']');
                }
            }

            return addressDefangBuilder.ToString();
        }
    }

    public class SecondSolution
    {
        public string DefangIPaddr(string address)
        {
            Span<char> addressDefangBuilder = stackalloc char[address.Length + 6];

            var indexOfSpan = 0;
            foreach (var addressPart in address)
            {
                if (addressPart != '.')
                {
                    addressDefangBuilder[indexOfSpan++] = addressPart;
                }
                else
                {
                    addressDefangBuilder[indexOfSpan++] = '[';
                    addressDefangBuilder[indexOfSpan++] = '.';
                    addressDefangBuilder[indexOfSpan++] = ']';
                }
            }

            return addressDefangBuilder.ToString();
        }
    }
}