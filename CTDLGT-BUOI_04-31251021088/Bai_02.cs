using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_BUOI_04_31251021088
{
    internal class Bai_02
    {
        public static void Main2224(string[] args)
        {
            string[] bien = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(bien[0]);
            int k = int.Parse(bien[1]);
            string[] mang = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(mang[i]);
            }

            int left = 0;
            int right = n - 1;
            int vi_tri = -1;
            int so_lan_lap = 0;
            while (left <= right)
            {
                so_lan_lap++;
                int mid = left + (right - left) / 2;

                if (a[mid] == k)
                {
                    vi_tri = mid;
                    break;
                }

                else if (a[mid] < k)
                {
                    left = mid + 1;
                }

                else
                {
                    right = mid - 1;
                }
            }

            Console.WriteLine($"{vi_tri} {so_lan_lap}");
        }
    }
}
