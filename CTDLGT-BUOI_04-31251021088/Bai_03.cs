using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_BUOI_04_31251021088
{
    internal class Bai_03
    {
        static int BinarySearch(int[] a, int n, int key)
        {
            int left = 0;
            int right = n - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (a[mid] == key)
                {
                    return mid; 
                }
                else if (a[mid] < key)
                {
                    left = mid + 1; 
                }
                else
                {
                    right = mid - 1; 
                }
            }

            return -1; 
        }

        public static void Main44444(string[] args)
        {
            string[] bien = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(bien[0]);
            int q = int.Parse(bien[1]);

            string[] mang = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(mang[i]);
            }

            string[] dong = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < q; i++)
            {
                int key = int.Parse(dong[i]);
                int result = BinarySearch(a, n, key);
                sb.AppendLine(result.ToString());
            }
            Console.Write(sb.ToString());
        }
    }
}

