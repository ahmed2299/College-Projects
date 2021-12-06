#include "employee.h"
#include <iostream>
#include <string>
#include <math.h>
using namespace std;
int main()
{
	int size;
	cout<<"enter the number of employees: ";
	cin>>size;
	string depart;
	employee *emp=new employee [size];
	for(int i=0;i<size;++i)
	{
		cout<<"input: "<<i+1<<endl;
		emp[i].readdata();
		
	}
	
	cout<<"enter specific department: ";
	cin>>depart;
	for(int i=0;i<size;i++)
	{
		emp[i].sumData(depart);
		emp[i].display(depart);
	}
	system("pause");
	return 0;
}