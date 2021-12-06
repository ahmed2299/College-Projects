#include "stacks.h"
#include<iostream>
using namespace std;
int binary(stacks &s,int &num){
	int rem;
	while(num>0){
		rem=num%2;
		s.push(rem);
		num=num/2;
	}
	return 0;
}
int main(){
	stacks s(5);
	/*int num;
		cin>>num;
		binary(s,num);
	while (!s.empty())
	{
		cout<<s.top();
		s.pop();
	}
	cout<<endl;*/
	s.push(10);
	s.push(10);
	s.push(10);
	s.push(10);
	s.push(10);
	s.push(10);
	s.push(10);
	s.push(5);
	cout<<s.top()<<endl;
	system("pause");
	return 0;
}