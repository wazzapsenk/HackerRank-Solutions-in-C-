using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        //odd numbers
        if (N % 2 == 1)
            {
            Console.WriteLine("Weird");
        }
        //greater than 2 and less than 5 and even numbers
        else if (N % 2 == 0 && N > 2 && N < 5 )
            {
            Console.WriteLine("Not Weird");
        }
        //greater than 6 and less than 20 even numbers
        else if (N % 2 == 0 && N >= 6 && N <= 20)
            {
            Console.WriteLine("Weird");
        }
        //greater than 20 even numbers
        else if (N % 2 == 0 && N > 20)
            {
            Console.WriteLine("Not Weird");
        }
              
    }
}
