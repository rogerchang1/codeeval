
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