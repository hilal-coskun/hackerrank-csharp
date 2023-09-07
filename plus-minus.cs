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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int negative = 0;
        int positive = 0;
        int zero = 0;
        
        double negativeRate = 0;
        double positiveRate = 0;
        double zeroRate = 0;
        double total = arr.Count;
        
        foreach(var i in arr){
            if(i>0){
                positive++;
            }
            else if(i<0){
                negative++;
            }
            else{
                zero++;
            }
        }
        
        negativeRate = (double)negative/total;
        positiveRate = (double)positive/total;
        zeroRate = (double)zero/total;
        
        Console.WriteLine(positiveRate.ToString("F6"));
        Console.WriteLine(negativeRate.ToString("F6"));
        Console.WriteLine(zeroRate.ToString("F6"));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
