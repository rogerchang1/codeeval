/*
Challenge Description:

You are given two strings 'A' and 'B'. Print out a 1 if string 'B' occurs at the end of string 'A'. Else a zero.
Input sample:

The first argument will be the path to the input filename containing two strings, comma delimited, one per line. Ignore all empty lines in the input file. E.g.

Hello World,World
Hello CodeEval,CodeEval
San Francisco,San Jose

Output sample:

Print out 1 if the second string occurs at the end of the first string. Else zero. Do NOT print out empty lines between your output. E.g.

1
1
0
*/

#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <fstream>
#include <sstream>
using namespace std;


int main(int argc, char* argv[])
{
ifstream fin;

fin.open(argv[1]);
while (!fin.eof())
{
string s1, s2;
getline(fin, s1, ',');
if (s1.empty()) continue;
getline(fin, s2);
if (s2.empty()) continue;
if (s1.find(s2) != string::npos)
cout << "1" << endl;
else
cout << "0" << endl;
}
fin.close();
return 0;
}