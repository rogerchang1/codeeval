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
