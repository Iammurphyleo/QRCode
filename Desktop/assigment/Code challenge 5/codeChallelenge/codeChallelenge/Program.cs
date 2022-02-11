using System;

namespace codeChallelenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] BinaryRoot =  { 3, 3, -2, 5, 2, 1, 10, -3, 11 };

            int Target = 7;
            //Target.ToString();

           

            string index = BinaryTree(BinaryRoot, Target);

            Console.Write( index);
        
        }
        public static string BinaryTree(int[] numbers, int Target)
        {
            
            string result = " ,";
            for (int i = 0; i <= numbers.Length - 2; i++)
            {
                for (int j = i + 1; j <= numbers.Length-1; j++)
                {
                    int a = numbers[i] + numbers[j];

                    
                    if (a == Target)
                    {
                         result = ($" {i}, {j}");

                        continue;
                    }
                    
                }
            }


            return result;


        }



    }
    


}
