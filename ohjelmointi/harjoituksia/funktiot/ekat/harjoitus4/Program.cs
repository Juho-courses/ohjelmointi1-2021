using System;
using System.Collections.Generic;

namespace harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lukuja = {1,2,3,4,5};
            int k = 3;
            int maara = FilterNumbers(k, lukuja);
            Console.WriteLine(maara);

            Console.WriteLine("FN2: " + FilterNumbers2(k, lukuja));
            
        }
        
        static int FilterNumbers2(int k, int[] arr) {
            List<int> lukui = new List<int>(arr);
            List<int> tmp = lukui.FindAll(x => (x >= k));
            return tmp.Count;
        }

        static int FilterNumbers(int k, int[] arr) {
            // maara montako arr on => k
            int maara = 0;
            foreach (var luku in arr)
            {
                if (luku >= k) {
                    maara++;
                }
            }
            return maara;
        }
    }
}
