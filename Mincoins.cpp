//You are given 3 coins of value 1, 3 and 5. You are also given a total which you have to arrive at. Find the minimum number of coins to arrive at it. 

#include <iostream>
#include <stdlib.h>
#include <vector>
#include <fstream>
#include <sstream>

using namespace std;

int main(int argc, char** argv){

	const int one = 1;
	const int three = 3;
	const int five = 5;

	string lineBuffer;
	ifstream file;

	file.open("input.txt");
	//file.open(argv[1]);

	while (!file.eof())
	{
		getline(file, lineBuffer);
		if (lineBuffer.length() == 0)
			continue; //ignore all empty lines
		else
		{
			int goal = atoi(lineBuffer.c_str());
			int sum = 0;
			int count = 0;
			while (sum < goal){
				if (sum + five <= goal){
					sum += five;
					count++;
				}
				else if (sum + three <= goal){
					sum += three;
					count++;
				}else{
					sum += one;
					count++;
				}
			}
			cout << count << endl;
		}
	}
	return 0;
}