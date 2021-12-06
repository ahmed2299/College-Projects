#include<iostream>
#include"arraylist.cpp"
using namespace std;
int main(){
	arraylist<int>s;
	//s.append(5);
	s.append(2);
	s.append(10);
	s.append(5);
	s.append(7);
	s.append(5);
	s.display();
	cout<<"..........................\n";
	s.removeAll(5);
	s.display();
}