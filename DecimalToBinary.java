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
