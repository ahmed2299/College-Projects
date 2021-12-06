#include "student.h"
student::student()
{
	total=0;
}
student::student(int std_id)
{
	id=std_id;
	total=0;
}
void student::readdata(){
	cout<<"id: ";
	cin>>id;
	for(int i=0;i<3;i++){
		cout<<"subject "<<i+1<<": ";
		cin>>marks[i];
	}
}
void student::sumdata(){
	for(int i=0;i<3;++i){
		total+=marks[i];
	}
	cout<<total<<endl;
}
void student::display(){
	for(int i=0;i<3;++i){
		cout<<total<<endl;
	}
}