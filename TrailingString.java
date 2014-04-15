/*
Challenge Description:

You are given two strings 'A' and 'B'. Print out a 1 if string 'B' occurs at the end of string 'A'. Else a zero.
Input sample:

The first argument will be the path to the input filename containing two strings, comma delimited, one per line. Ignore all empty lines in the input file. E.g.

Hello World,World
Hello CodeEval,CodeEval
San Francisco,San Jose

Output sample:

Print out 1 if the second string occurs at the end of the first string. Else zero. Do NOT print out empty lines between your output. E.g.

1
1
0
*/
import java.io.*;

public class Main {

    
	public static void main(String []args){
		
		File file = new File(args[0]);
		BufferedReader in;
		String delim = "[ ]+";
		try{
			in = new BufferedReader(new FileReader(file));
			String line;
			while((line=in.readLine())!=null){
				String[] lineArray = line.split(",");
				String string1 = lineArray[0];
				String string2 = lineArray[1];
				if(string1.length()-string2.length()>=0){
					String leftover = string1.substring(string1.length()-string2.length(),string1.length());
					if(leftover.compareTo(string2)==0)
						System.out.println("1");
					else
						System.out.println("0");
				}
			}
		}catch (IOException e){
			e.printStackTrace();
		}
	}
}
