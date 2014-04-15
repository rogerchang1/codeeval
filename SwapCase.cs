/*

Swap Case
Challenge Description:

Write a program which swaps letters' case in a sentence. All non-letter characters should remain the same.
Input sample:

Your program should accept as its first argument a path to a filename. Input example is the following

Hello world!
JavaScript language 1.8
A letter

Output sample:

Print results in the following way.

hELLO WORLD!
jAVAsCRIPT LANGUAGE 1.8
a LETTER


*/
using System.IO;
using System.Collections.Generic;
using System;

class Program
    {
	    static void Main(string[] args)
	    {
	        
	    	using (StreamReader reader = File.OpenText(args[0]))
	        while (!reader.EndOfStream)
	        {
	            string line = reader.ReadLine();
	            if (null == line)
	                continue;
	           // Console.WriteLine(line);
	            // do something with line
	            for(int i=0;i<line.Length;i++){
	            	char a = line[i];
	            	if( (int) a > 96 && (int) a < 123){
	            		a = (char) ((int) a-32);
	            		Console.Write(a);
	            	}else if( (int) a > 64 && (int) a < 91){
	            		a = (char) ((int) a+32);
	            		Console.Write(a);
	            	}else{
	            		Console.Write(a);
	            	}
	            }
	            Console.WriteLine();
	        }
	    	Console.ReadKey(true);
	    }
	}