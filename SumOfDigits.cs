/*

Sum of Digits
Challenge Description:

Given a positive integer, find the sum of its constituent digits.
Input sample:

The first argument will be a path to a filename containing positive integers, one per line. E.g.

23
496

Output sample:

Print to stdout, the sum of the numbers that make up the integer, one per line. E.g.

5
19


*/
using System.IO;
using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
    		//using (StreamReader reader = File.OpenText("C:/Users/rogerchang/workspace/CodeEval/src/sumdigitstest.txt"))
	        while (!reader.EndOfStream)
	        {
	            string line = reader.ReadLine();
	            if (null == line)
	                continue;
	            int a=0;
	            for(int i=0;i<line.Length;i++){
	            	a += Int32.Parse(line[i].ToString());
	            }
	            Console.WriteLine(a);
	        }
	    	Console.ReadKey(true);
    }
}