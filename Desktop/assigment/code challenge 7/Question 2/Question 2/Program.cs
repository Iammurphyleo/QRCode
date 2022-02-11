using System;
using System.Collections.Generic;
using System.Collections;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Question();
            //int[] numbers = {1, 1,1,1 };
            // List<int> k= new List<int>();
            ////int[] numbers = { 1, 4, 3, 3, 5, 2, 3, 7, 6, 8, 2 };

            //int[] numbers = { 1, 3, 2, 2, 5, 2, 3, 7 };

            //int count = 0;
            //int max = 0; 

            //for (int i = 0; i < numbers.Length ; i++)
            //{
            //    for (int j = 0; j < numbers.Length ; j++)
            //    {
            //        if (numbers[i] - numbers[j] == 1 || numbers[i] == numbers[j])
            //        {
            //            count++;

            //        }
            //        if(count > max) 
                    
            //        {
            //            max = count;
                    
            //        }

            //    }
            //    count = 0;

                
                
            
            
            //}
            //if (max == numbers.Length) 
            //{
            //    Console.WriteLine(0);
            //}
            //else 
            //{
            //    Console.WriteLine(max);
            //}

            

        }
        public static void Question()
        {
            int[] a = new int[] { 1, 3, 5, 7, 9 };
            HashSet<int> w = new HashSet<int>();
            Hashtable ht = new Hashtable();
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        if (a[i] - a[j] == 1)
                        {
                            w.Add(a[i]);
                            w.Add(a[j]);
                        }

                    }
                    else
                    {
                        if (a[j] - a[i] == 1)
                        {
                            w.Add(a[j]);
                            w.Add(a[i]);
                        }
                    }

                }
      
            }
            foreach (var d in w)
            {
                ht.Add(d, 0);
            }
            foreach(var t in a)
            {
                if(ht.ContainsKey(t))
                {
                    ht[t] = (int)ht[t] + 1;
                }
            }
            List<int> list1 = new List<int>();
            List<int> list = new List<int>();
            foreach(DictionaryEntry entry in ht)
            {
                list.Add((int)entry.Key);
                list1.Add((int)entry.Value);
            }
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count-1; j++)
                {
                    if (list[j] > list[j+1])
                    {
                        int tem = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tem;


                        int temp = list1[j];
                        list1[j] = list1[j + 1];
                        list1[j + 1] = temp;

                    }
                }

            }
            int c = 0;
            int y = 0;
            for(int i = 0;i < list.Count-1;i++)
            {
                if (list[i + 1] - list[i] == 1)
                {
                    c = (list[i] * list1[i]) + (list[i + 1] * list1[i + 1]);
                }
                if(c > y)
                {
                    y = c;
                }
            }
            Console.WriteLine(y);
            
        }

   
    
    
    
    
    
    
    }






}
