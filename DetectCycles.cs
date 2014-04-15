
using System.IO;
using System.Collections.Generic;
using System;

class Program
{
    public static void detectCycle(string[] lineArray){
        	int i=0;
            int j=0;
            string result = "";
   			Boolean isCycle= false;
            for(i=0;i<lineArray.Length;i++){
            	for(j=i+1;j<lineArray.Length;j++){
            		if(lineArray[i].CompareTo(lineArray[j])==0){
            			result = compareString(i,j,lineArray);
            			if(result.CompareTo("")!=0){
            				isCycle=true;
            				break;
            			}
            		}
            	}
   				if(isCycle) break;
            }
   			Console.WriteLine(result);
		}
		
		public static string compareString(int i, int j, string[] lineArray){
			int length = j-i;
			if(j+(length) > lineArray.Length) return "";
			string a = "";
			string b = "";
			for(int cnt = 0; cnt < length; cnt ++){
				a+=lineArray[i+cnt]+" ";
				b+=lineArray[j+cnt]+" ";
			}
			if(a.CompareTo(b)==0){
				return a;
			}
			return "";
		}
		
		public static void Main(String [] args)
		{
			using (StreamReader reader = File.OpenText(args[0]))
			
	        while (!reader.EndOfStream){
	            string line = reader.ReadLine();
	            if (null == line)
	                continue;
	            string[] lineArray = line.Split(' ');
	            detectCycle(lineArray);

	        }
	    	Console.ReadKey(true);
		}
}