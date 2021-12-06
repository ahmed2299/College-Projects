#include<iostream>
using namespace std;
class student{
	int id;
	double marks[3];
	int total;
public:
	student();
	student(int std_id);
	void readdata();
	void sumdata();
	void display();

};