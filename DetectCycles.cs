/*
Challenge Description:

Given a sequence, write a program to detect cycles within it.
Input sample:

Your program should accept as its first argument a path to a filename containing a sequence of numbers (space delimited). The file can have multiple such lines. E.g

2 0 6 3 1 6 3 1 6 3 1
3 4 8 0 11 9 7 2 5 6 10 1 49 49 49 49
1 2 3 1 2 3 1 2 3

Output sample:

Print to stdout the first cycle you find in each sequence. Ensure that there are no trailing empty spaces on each line you print. E.g.

6 3 1
49
1 2 3

*/
using System.IO;
using System.Collections.Generic;
using System;

class Program
{
    public static void detectCycle(string[] lineArray){
        	int i=0;
            int j=0;
            string result = "";
   			Boolean isCycle= false;
            for(i=0;i<lineArray.Length;i++){
            	for(j=i+1;j<lineArray.Length;j++){
            		if(lineArray[i].CompareTo(lineArray[j])==0){
            			result = compareString(i,j,lineArray);
            			if(result.CompareTo("")!=0){
            				isCycle=true;
            				break;
            			}
            		}
            	}
   				if(isCycle) break;
            }
   			Console.WriteLine(result);
		}
		
		public static string compareString(int i, int j, string[] lineArray){
			int length = j-i;
			if(j+(length) > lineArray.Length) return "";
			string a = "";
			string b = "";
			for(int cnt = 0; cnt < length; cnt ++){
				a+=lineArray[i+cnt]+" ";
				b+=lineArray[j+cnt]+" ";
			}
			if(a.CompareTo(b)==0){
				return a;
			}
			return "";
		}
		
		public static void Main(String [] args)
		{
			using (StreamReader reader = File.OpenText(args[0]))
			
	        while (!reader.EndOfStream){
	            string line = reader.ReadLine();
	            if (null == line)
	                continue;
	            string[] lineArray = line.Split(' ');
	            detectCycle(lineArray);

	        }
	    	Console.ReadKey(true);
		}
}