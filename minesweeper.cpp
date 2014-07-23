//You will be given an M*N matrix. Each item in this matrix is either a '*' or a '.'. A '*' indicates a mine whereas a '.' does not. The objective of the challenge is to output a M*N matrix where each element contains a number (except the positions which actually contain a mine which will remain as '*') which indicates the number of mines adjacent to it. Notice that each position has at most 8 adjacent positions e.g. left, top left, top, top right, right, ... 

#include <iostream>
#include <stdlib.h>
#include <vector>
#include <fstream>
#include <sstream>

using namespace std;

int countMines(char**table, int m, int n, int i, int j){
	int count = 0;
	if (i - 1 != -1 && j - 1 != -1){
		if (table[i - 1][j - 1] == '*')
			count++;
	}
	if (i - 1 != -1){
		if (table[i - 1][j] == '*')
			count++;
	}
	if (i - 1 != -1 && j + 1 != n){
		if (table[i - 1][j + 1] == '*')
			count++;
	}
	if (j - 1 != -1){
		if (table[i][j - 1] == '*')
			count++;
	}
	if (j + 1 != n){
		if (table[i][j + 1] == '*')
			count++;
	}
	if (i + 1 != m && j - 1 != -1){
		if (table[i + 1][j - 1] == '*')
			count++;
	}
	if (i + 1 != m){
		if (table[i + 1][j] == '*')
			count++;
	}
	if (i + 1 != m && j + 1 != n){
		if (table[i + 1][j + 1] == '*')
			count++;
	}
	return count;
}

void printOutput(char** table, int m, int n){

	for (int i = 0; i < m; i++){
		for (int j = 0; j < n; j++){
			if (table[i][j] == '*')
				cout << '*';
			else
				cout << countMines(table, m, n, i, j);
		}
	}
	cout << endl;
}

void mineSweeper(string line){
	int m;
	int n;
	int i;

	string temp = "";
	for (i = 0; i < line.size(); i++){
		if (line[i] == ','){
			m = atoi(temp.c_str());
			temp = "";
		}
		else if (line[i] == ';'){
			n = atoi(temp.c_str());
			break;
		}
		else{
			temp += line[i];
		}
	}
	char** table = new char*[m];
	for (int j = 0; j < m; j++){
		table[j] = new char[n];
	}
	i++;
	for (int x = 0; x < m;x++){
		for (int y = 0; y < n; y++){
			table[x][y] = line[i];
			i++;
		}
	}
	printOutput(table, m, n);
}


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
			mineSweeper(lineBuffer);
		}
	}
	return 0;
}