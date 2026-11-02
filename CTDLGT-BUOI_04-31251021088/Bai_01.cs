using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_BUOI_04_31251021088
{
    internal class Bai_01
    {
        static int TimTuanTu(int[] a, int k)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == k) return i;
            }
            return -1;
        }
        public static void Main111(string[] args)
        {
            string[] bien = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(bien[0]);
            int k = int.Parse(bien[1]);
            string[] mang = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(mang[i]);
            }

            int kq = TimTuanTu(a, k);
            Console.WriteLine(kq);
        }
    }
}