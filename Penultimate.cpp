//Write a program which finds the next-to-last word in a string. 

#include <iostream>
#include <stdlib.h>
#include <vector>
#include <fstream>
#include <sstream>

using namespace std;

vector<string> parseIntoVector(string s){
	vector <string> list;
	string temp = "";
	for (int i = 0; i < s.size(); i++){
		if (s[i] == ' ' && temp!=""){
			list.push_back(temp);
			temp = "";
		}
		else{
			temp += s[i];
		}
	}
	if (temp != "")
		list.push_back(temp);
	return list;
}

int main(int argc, char** argv){

	string lineBuffer;
	ifstream file;
	vector<string> list;

	//file.open("input.txt");
	file.open(argv[1]);

	while (!file.eof())
	{
		getline(file, lineBuffer);
		if (lineBuffer.length() == 0)
			continue; //ignore all empty lines
		else
		{
			list = parseIntoVector(lineBuffer);
			if (list.size()>1)
				cout << list.at(list.size() - 2).c_str() << endl;
		}
	}
	return 0;
}