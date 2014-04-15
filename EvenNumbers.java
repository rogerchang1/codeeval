/*

Even Numbers
Challenge Description:

Write a program which checks input numbers and determines whether a number is even or not.
Input sample:

Your program should accept as its first argument a path to a filename. Input example is the following

701
4123
2936

Output sample:

Print 1 if the number is even or 0 if the number is odd.

0
0
1

All numbers in input are integers > 0 and < 5000.
*/

import java.io.*;
import java.util.Arrays;

public class Main {
    public static void main (String[] args) {

    File file = new File(args[0]);
    try{
    BufferedReader in = new BufferedReader(new FileReader(file));
    String line;
    while ((line = in.readLine()) != null) {
        String[] lineArray = line.split(" ");
        if (lineArray.length > 0) {
            if(Integer.parseInt(lineArray[0])%2==0)
                System.out.println("1");
            else 
                System.out.println("0");
        }
    }
    }catch(IOException e) {
    	// TODO Auto-generated catch block
		e.printStackTrace();
	}
  }
}
