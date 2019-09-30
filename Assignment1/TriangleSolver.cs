using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public static class TriangleSolver
    {
        public static string TriangleType(int len1, int len2, int len3)
            {
            if ( len2 + len3 >=len1 && len1 + len2 >= len3 && len1 + len3 >= len2)
            {

                if (len1 == len2 && len2 == len3 && len3 == len1)

                {
                    return("Triangle is equilateral.");
                }
                else if (len1 == len2 || len2 == len3 || len3 == len1)
                {
                    return("Triangle is isosceles.");
                }
                else
                {
                    return ("Triangle is  is scalene.");
                }
            }
            else
            {
                return ("Cannot form a triangle.");
            }
            

            }

    }
}
