using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class Program3
    {
        public static void main()
        {
            int[] arr = new int[15].Select(x => new Random().Next(100)).ToArray().Print();
            arr[0..5].Concat(new int[] { 12345 }).Concat(arr[5..^0]).ToArray().Print();
        }
    }
}
