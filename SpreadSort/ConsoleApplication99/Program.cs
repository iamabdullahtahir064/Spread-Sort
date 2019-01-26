using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication99
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[5] { 115,12,11,14,13}; 
            buckets(arr,arr.Length);
            
        }
       
        public static void buckets(int[] data,int count)

        {
            List<int> list = new List<int>();
            List<int>[] buckets = new List<int>[count];
            for (int i = 0; i < count; i++)
            {
                buckets[i] = new List<int>();
            }
            for (int i = 0; i < count; i++)
            {
                int bucketchoice = (data[i] / 10);
                buckets[bucketchoice].Add(data[i]);
            }
            for (int i=0;i<count;i++)
            {
              quicksort(buckets[i].ToArray(), 0, buckets[i].Count);
                list.AddRange(buckets[i]);
            }
              list.ForEach(Console.WriteLine);
            


        }
        public static void quicksort(int[] data,int start,int end)
        {
            if (start < end)
          {
              int pindex = partition(data, start, end);
                quicksort(data, start, pindex-1);
                quicksort(data, pindex + 1, end);

          }
        }
        public static int partition(int[] data,int start,int end)
        {
            int pivot = data[end];
            int pindex = start;
            for (int i = start; i <= end - 1; i++)
            {
                if (data[i] < pivot)
                {
                    int temp = data[pindex];
                    data[pindex] = data[i];
                    data[i] = temp;
                    pindex = pindex + 1;
                }
            }
            int temp1 = data[end];
            data[end] = data[pindex];
            data[pindex] = temp1;
            return pindex;
        }
    }
    
}
