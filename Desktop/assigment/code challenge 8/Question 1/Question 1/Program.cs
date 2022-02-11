using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "ax";
           string p = a.Substring(0, 2);

            string b = "xa";
           string o = b.Substring(0, 2);

            string c = "bax";

            string m = c.Substring(0, 2);

            string n = c.Substring(1, 2);

            string k = "";
            string j = "";

            for(int i = m.Length-1; i >= 0; i-- ) 
            {
                k += m[i];
            }

            for(int i = n.Length-1; i>=0; i--) 
            {
                j += n[i];
            }

            if (p == k || p == j) 
            {
                Console.WriteLine(p);  
            
            }
            else if (o == k || o == j) 
            {
                Console.WriteLine(o);
            }
           


            

        }

        
    
    }
}
