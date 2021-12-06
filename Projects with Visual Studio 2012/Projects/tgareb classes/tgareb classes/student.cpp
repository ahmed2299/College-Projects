#include "student.h"
#include<iostream>
#include<vector>
using namespace std;

student::student()
{
	numOfStudents=0;
}
void student::readData(){
	cout<<"enter the name of depart :";
	cin>>name;
	cout<<"enter the number of students in the depart :";
	cin>>numOfStudents;

}
int student::Display(){
	
	return numOfStudents;
}
student::~student(void)
{
}
