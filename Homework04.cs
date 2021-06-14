using System;

namespace MyApplication
{
    class Homework04
    {
        private const int V = 0;

        static void Main(string[] args)
        {
            string number;
            Console.Write("Enter your number:");
            number = Console.ReadLine();
            string[] words = number.Split(',');
            foreach (var word in words)
            {
                int i = (word.Length - 1);
                double sum = 0, j = 0;
                while (i >= 0)
                {
                    sum += Convert.ToDouble(word.Substring(i,1)) *
                           Convert.ToDouble(Math.Pow(2.00, Convert.ToDouble(j)));
                    j++;
                    i--;
                }

                if (sum % 5 == 0){
                    Console.Write(word+" ");
                }
                
            }
            
        }
    }
}
