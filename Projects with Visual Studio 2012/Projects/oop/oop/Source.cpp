#include "student.h"
#include<iostream>
using namespace std;
int main(){
	int studsnum;
	cout<<"enter the number of students: ";
	cin>>studsnum;
	student *studs=new student[studsnum];
	for(int i=0;i<studsnum;++i){
		cout<<"student :"<<i+1<<endl;
		studs[i].readdata();
		
	}
	for(int i=0;i<studsnum;++i){
		cout<<"student :"<<i+1<<endl;
		studs[i].sumdata();
	}
	return 0;
}