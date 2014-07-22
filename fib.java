//The Fibonacci series is defined as: F(0) = 0; F(1) = 1; F(n) = F(n-1) + F(n-2) when n>1. Given a positive integer 'n', print out the F(n). 

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.io.BufferedReader;
import java.util.Arrays;

public class Main {
    
    public static int fib(int n){
        if(n==0) return 0;
        if(n==1) return 1;
        return (fib(n-1)+fib(n-2));
        
    }
    
    public static void main (String[] args) {
        File file = new File(args[0]);
    	    BufferedReader in;
			try {
				in = new BufferedReader(new FileReader(file));
		    String line;
				while ((line = in.readLine()) != null) {
				    String[] lineArray = line.split(" ");
				    if (lineArray.length > 0) {
				    	int n = Integer.parseInt(lineArray[0]);
				    	System.out.println(fib(n));
				    }
				}
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
    }
}
