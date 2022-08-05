using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int i_=Convert.ToInt32(Console.ReadLine());
        double d_=Convert.ToDouble(Console.ReadLine());
        double sum=d+d_;
        string s_=Convert.ToString(Console.ReadLine());
        // Read and save an integer, double, and String to your variables.
        
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i+i_);
        // Print the sum of the double variables on a new line.
        Console.WriteLine(String.Format("{0:F1}", sum)); //F1 is Indicates the number of digits to be written after the dot.
        //For example if would be {0:F3} result was 8.000 
        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + s_);
        // The 's' variable above should be printed first.

    }
