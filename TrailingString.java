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
