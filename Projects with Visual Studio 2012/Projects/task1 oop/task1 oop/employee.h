#include<iostream>
#include<string>
using namespace std;
class employee{

	string name;
	string department;
	double salary;
	int date;
	double sum;
public:
	employee();
	employee(string nam,int sal);
	void display(string apart);
	void sumData(string apart);
	void readdata();
};