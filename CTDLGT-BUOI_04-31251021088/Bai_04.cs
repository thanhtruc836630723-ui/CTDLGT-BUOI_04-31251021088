using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_BUOI_04_31251021088
{
    internal class Bai_04
    {
        static int BinarySearch(int[] keys, int n, int targetKey)
        {
            int left = 0;
            int right = n - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (keys[mid] == targetKey)
                {
                    return mid;
                }
                else if (keys[mid] < targetKey)
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

        public static void Main(string[] args)
        {
            
            string[] line1 = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(line1[0]);
            int q = int.Parse(line1[1]);

            int[] keys = new int[n];
            int[] values = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] record = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                keys[i] = int.Parse(record[0]);
                values[i] = int.Parse(record[1]);
            }

        
            string[] queries = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < q; i++)
            {
                int queryKey = int.Parse(queries[i]);

             
                int index = BinarySearch(keys, n, queryKey);

                if (index != -1)
                { 
                    sb.AppendLine(values[index].ToString());
                }
                else
                {
                   
                    sb.AppendLine("NOT FOUND");
                }
            }

            Console.Write(sb.ToString());
        }
    }
}
