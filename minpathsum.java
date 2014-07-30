/*You are given an n*n matrix of integers. You can move only right and down. Calculate the minimal path sum from the top left to the bottom right */

import java.io.*;

public class minpathsum {
		
		
	
		static public void minPathSum(int[][] matrix, int size){			
			int[][] sum = new int[size][size];
			sum[0][0] = matrix[0][0];
			
			for(int i=0;i<size;i++){
				for(int j=0;j<size;j++){
					if(i==0&&j!=0) sum[i][j]=matrix[i][j]+sum[i][j-1];
					if(i!=0&&j==0) sum[i][j]=matrix[i][j]+sum[i-1][j];
					if(i!=0&&j!=0){
						int a = matrix[i][j]+sum[i][j-1];
						int b = matrix[i][j]+sum[i-1][j];
						if(a<b)
							sum[i][j] = a;
						else
							sum[i][j] = b;
					}
				}
			}
			System.out.println(sum[size-1][size-1]);
		}
		
	    public static void main(String[]args){

			File file = new File(args[0]);
			BufferedReader in;
			String delim = "[,]+";
			
			try{
				
				in = new BufferedReader(new FileReader(file));
				String line;
				int i = 0;
				int size = 0;
				int [][] matrix = null;
				while((line=in.readLine())!=null){
					
					
					String[] lineArray = line.split(delim);
					
					if(lineArray.length==1){
						size = Integer.parseInt(lineArray[0]);
						matrix = new int[size][size];
					}else{
						for(int j=0;j<size;j++){
							matrix[i][j]=Integer.parseInt(lineArray[j]);
						}
						i++;
					}
						
					if(i==size){
						minPathSum(matrix, size);
						i=0;
						matrix=null;
						size=0;
					}
				}
			}catch (IOException e){
				e.printStackTrace();
			}
	
		}

}

