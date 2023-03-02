using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp2
{
    public static class EngineExtentions
    {
        public static bool isInMatrixBounds<T>(this T[,] matrix,MyVector2 matrixIndex) 
        {
            if(matrixIndex.X < matrix.GetLength(1) && matrixIndex.X > -1 && matrixIndex.Y < matrix.GetLength(0) && matrixIndex.Y > -1)
                return true;
            return false;
        }

        public static string SmallCapsToBigCap(this string smallCaps)
        {
            for (int i = 0; i < smallCaps.Length; i++)
            {
                if (smallCaps[i] >= 65 && smallCaps[i] <= 90)
                    smallCaps = smallCaps.Replace(smallCaps[i], Convert.ToChar(smallCaps[i] + 33));//delta value in ascii table from small cap to big cap
            }
            return smallCaps; 
        }

        public static bool IsArrayNullOrEmpty<T>(this T[] array) 
        {
            if (array == null || array.Length<0)
                return true;
            return false;
        }


    }
}
