using System;
namespace WorkShopPro
{
    public class Program
    {
        static int higestPowerOf2(int n)
        {
            int P = 0;
            for (int i = n; i >= 1; i--)
            {
                if ((i & (i - 1) == 0)

               {
                    P = i;
                    break;
                }
            }
            return p;

        }
        static public void Main()
        {
            int n = 12;
            Console.WriteLine(higestPowerOf2(n))
        }
    }


