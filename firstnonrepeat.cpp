//Write a program to find the first non repeated character in a string

#include <iostream>
#include <stdlib.h>
#include <vector>
#include <fstream>
#include <sstream>

using namespace std;

char findNonRepeatChar(string s){

    int* alphabet = new int[26];
    int index;
    char output = s[0];;
    for(int i=0;i<26;i++){
        alphabet[i]=0;
    }

    for(int i=0;i<s.length();i++){
        index = s[i]-97;
        alphabet[index]++;
    }

    for(int i=0;i<s.length();i++){
        index = s[i]-97;
        if(alphabet[index]==1){
            output=s[i];
            break;
        }
    }
	return output;
}
int main(int argc, char** argv){

	string lineBuffer;
	ifstream file;
	//file.open("input.txt");
	file.open(argv[1]);
	while (!file.eof()){
		getline(file, lineBuffer);
		if (lineBuffer.length() == 0)
			continue; //ignore all empty lines
		else
			cout << findNonRepeatChar(lineBuffer) << endl;
	}
	return 0;
}
