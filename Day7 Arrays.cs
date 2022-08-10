using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        //creating Reverse Format
        ReversePrint(arr);
    }
    private static void ReversePrint(List<int> arr)
    {
        int length=arr.Count;
        for (int i=length-1;i>=0;i--)
        {
            if(i != 0)
            {
                Console.Write(arr[i]+" ");
            }
            else
            {
                Console.Write(arr[i]);
            }
        }
    }
}
