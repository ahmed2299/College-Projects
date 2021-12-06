#include "students.h"
#include <iostream>
using namespace std;
students::students()
{id=0;
gpa=0;
name="";
departmentName="";
}
float students::getGpa(){
	return gpa;
}
string students::getDepartment(){
	return departmentName;
}
void students::input(){
	cout<<"ID: ";
	cin>>id;
	cout<<"name: ";
	cin>>name;
	cout<<"gpa: ";
	cin>>gpa;
	cout<<"depx: ";
	cin>>departmentName;
}
string students::Name(){
	return name;
}

students::~students(void)
{
}