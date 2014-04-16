/*
 * Challenge Description:

Imagine we have an immutable array of size N which we know to be filled with integers ranging from 0 to N-2, inclusive. Suppose we know that the array contains exactly one duplicated entry and that duplicate appears exactly twice. Find the duplicated entry. (For bonus points, ensure your solution has constant space and time proportional to N)
Input sample:

Your program should accept as its first argument a path to a filename. Each line in this file is one test case. Ignore all empty lines. Each line begins with a positive integer(N) i.e. the size of the array, then a semicolon followed by a comma separated list of positive numbers ranging from 0 to N-2, inclusive. i.e eg.
1
2
5;0,1,2,3,0
20;0,1,10,3,2,4,5,7,6,8,11,9,15,12,13,4,16,18,17,14
Output sample:

Print out the duplicated entry, each one on a new line eg
1
2
0
4
*/
using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    public static void findDuplicate(string[] array){
		HashSet<string> hash = new HashSet<string>();
		
		for(int i=1;i<array.Length;i++){
			if(!hash.Contains(array[i]))
			   hash.Add(array[i]);
			else
				Console.WriteLine(array[i]);
		}
	}
    
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            string[] lineArray = Regex.Split(line, "[;,]+");
            findDuplicate(lineArray);
        }
    	Console.ReadKey(true);
    }
}