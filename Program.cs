using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class FileName
    {
        static int index(int[] myArr, int a)
        {
            
            for (int i = 0; i < myArr.Length; i++)
            {
                
                if (myArr[i] == a)
                    return i;        
            }
            return -1;
        }
        static void Main(string[] args)
        {

            int[] myArr = { 1, 76, 3, 4, 2 };
            Console.WriteLine(index(myArr, 8));



        }
    }
}
