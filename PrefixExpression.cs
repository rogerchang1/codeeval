/*
Challenge Description:

You are given a prefix expression. Write a program to evaluate it.
Input sample:

Your program should accept as its first argument a path to a filename. The file contains one prefix expression per line. E.g.
1
* + 2 3 4

Your program has to read this and insert it into any data structure you like. Traverse that data structure and evaluate the prefix expression. Each token is delimited by a whitespace. You may assume that the only valid operators appearing in test data are '+','*' and '/'(floating-point division).
Output sample:

Print to stdout, the output of the prefix expression, one per line. E.g.
1
20

Constraints:
The evaluation result will always be an integer >= 0.
The number of the test cases is <= 40. 
 */
using System.IO;
using System.Collections.Generic;
using System;

class Program
{
    
        public static Boolean isInteger(string input){
        	float value;
			if(float.TryParse(input, out value)) return true;
			else return false;
		}
		
		public static Boolean isOperator(string input){
			return (input.CompareTo("+")==0 || input.CompareTo("*")==0 || input.CompareTo("/")==0);
		}
		
			public static string eval(string[] input){
			
			Stack <string> stack = new Stack<string>();
			
			for(int i = 0; i < input.Length; i++){
				if(isOperator(input[i]))
				   stack.Push(input[i]);
				else{
				   	if(isOperator(stack.Peek()))
				   		stack.Push(input[i]);
				   	else{
				   		float a = Convert.ToSingle(input[i]);
				   		float b = Convert.ToSingle(stack.Pop());
				   		float result;
				   		string oper = stack.Pop();
				   		switch (oper){
				   			case "+" : 
				   				result=b+a;
				   				stack.Push(result.ToString("R"));
				   				break;
				   			case "*" : 
				   				result=b*a;
				   				stack.Push(result.ToString("R"));
				   				break;
				   			case "/" : 
				   				result=b/a;
				   				stack.Push(result.ToString("R"));
				   				break;
				   		}
				   	}		
				}
			}
			return stack.Pop();
		}
    
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            string[] array = line.Split(' ');
            Console.WriteLine(eval(array));
        }
        Console.ReadKey(true);
    }
}