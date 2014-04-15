/*

Decimal To Binary
Challenge Description:

Given a decimal (base 10) number, print out its binary representation.
Input sample:

Your program should accept as its first argument a path to a filename containing whole decimal numbers greater or equal to 0, one per line.
Ignore all empty lines. E.g.

2
10
67

Output sample:

Print the binary representation, one per line. E.g.

10
1010
1000011

*/

import java.io.*;

public class Main {

    public static void main(String[]args){
		
		File file = new File(args[0]);
		
		BufferedReader in;
		String delim = "[ ]+";
		try{
			in = new BufferedReader(new FileReader(file));
			String line;
			while((line=in.readLine())!=null){
				String[] lineArray = line.split(delim);
				int num = Integer.parseInt(lineArray[0]);
				String binaryNum = Integer.toBinaryString(num);
				System.out.println(binaryNum);
			}
		}catch (IOException e){
			e.printStackTrace();
		}
		
	}
	
}
