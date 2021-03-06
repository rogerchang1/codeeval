/*

Longest Common Subsequence
Challenge Description:

You are given two sequences. Write a program to determine the longest common subsequence between the two strings (each string can have a maximum length of 50 characters). NOTE: This subsequence need not be contiguous. The input file may contain empty lines, these need to be ignored.
Input sample:

The first argument will be a path to a filename that contains two strings per line, semicolon delimited. You can assume that there is only one unique subsequence per test case. E.g.

XMJYAUZ;MZJAWXU

Output sample:

The longest common subsequence. Ensure that there are no trailing empty spaces on each line you print. E.g.

MJAU

*/
using System.IO;
using System.Collections.Generic;
using System;

class Program
{
    
     public static int max(int a, int b){
    	 	return ( a > b ) ? a : b;
		 }
		 
		 public static int[,] fillTable(string a, string b){
		 	
		 	int m = a.Length+1;
		 	int n = b.Length+1;
		 	int [,]table = new int[m,n];
		 	
		 	for (int i = 0; i < m; i++){
		 		for(int j = 0; j < n; j++){
		 			table[i,j]=0;
		 		}
		 	}
		 	
		 	for (int i = 1; i < m; i++){
		 		for(int j = 1; j < n; j++){
		 			if(a[i-1] == b[j-1])
		 				table[i,j] = table[i-1,j-1] + 1;
		 			else
		 				table[i,j] = max( table[i-1,j], table[i,j-1]);
		 			
		 		}
		 	}
		 	return table;
		 }
		
		 public static string getLCS(int[,] table, string a, string b, int i, int j){
		 	if(i <= 0 || j <= 0)
		 		return "";
		 	else if(a[i-1] == b[j-1])
		 		return getLCS(table, a, b, i-1, j-1) + a[i-1];
		 	else if(table[i-1,j] > table[i,j-1])
		 		return getLCS(table, a, b, i-1, j);
		 	else
		 		return getLCS(table, a, b, i, j-1);	
		 }
    
    static void Main(string[] args)
    {
            using (StreamReader reader = File.OpenText(args[0]))
	        while (!reader.EndOfStream)
	        {
	            string line = reader.ReadLine();
	            if (null == line)
	                continue;
	            string[] lineArray = line.Split(';');
	            string a = lineArray[0];
	            string b = lineArray[1];
	            int[,] table = fillTable(a,b);
	            string output = getLCS(table,a,b,a.Length,b.Length);
	            Console.WriteLine(output);
	        }
	    	Console.ReadKey(true);
    }
}