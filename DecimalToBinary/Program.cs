using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide a decimal number up to 15 : ");
            AskNumberFromUser();
        }

        static void AskNumberFromUser()
        {
            string dec = Console.ReadLine();
            int num = int.Parse(dec);
            if (num == 0) 
                Console.WriteLine("The coresponding Binary is 0");
            else
            {
                CheckIfNumberIsValid(num);
                CalculateBinary(num);
            }
                
        }

        static void CheckIfNumberIsValid(int num)
        {
            if(num<0 || num>15)
            {
                Console.WriteLine("Wrong Input. Please provide a decimal number up to 15");
                AskNumberFromUser();
            }
        }

        static void CalculateBinary(int num)
        {
            int i = 0;
            int[] arr = new int[4];
            while(num>0)
            {
                arr[i++] = num % 2;
                num /= 2;
            }

            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(arr[j]);
            }
            Console.WriteLine("\n");
        }

    }
}
