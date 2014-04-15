import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.io.BufferedReader;
import java.util.Arrays;

public class Main {
    public static void main (String[] args) {
        File file = new File(args[0]);
    	    BufferedReader in;
			try {
				in = new BufferedReader(new FileReader(file));
		    String line;
				while ((line = in.readLine()) != null) {
				    String[] lineArray = line.split(" ");
				    if (lineArray.length > 0) {
				    	int i = 0;
				    	while(i<lineArray.length){
				    		lineArray[i]=lineArray[i].toLowerCase();
				    		System.out.print(lineArray[i] + " ");
				    		i++;
				    	}
				    	System.out.println();
				    }
				}
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
    }
}
