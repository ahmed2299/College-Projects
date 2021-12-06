#include "employee.h"
employee::employee()
{
	sum=0;
}
employee::employee(string nam,int sal)
{
	name=nam;
	salary=sal;
	sum=0;
}
void employee::readdata()
{
	cout<<"Name: ";
	cin>>name;
	cout<<"Department: ";
	cin>>department;
	cout<<"Base salary: ";
	cin>>salary;
	cout<<"employment date: ";
	cin>>date;
}
void employee::sumData(string apart){
	if(apart==department)
	sum=salary+salary*0.2;
}
void employee::display(string apart)
{
	if(apart==department){
	cout<<"The total salary is: ";
	cout<<sum<<endl;
	cout<<"Employment name is: ";
	cout<<name<<endl;
	cout<<"Employment Department is: ";
	cout<<department<<endl;
	}
}