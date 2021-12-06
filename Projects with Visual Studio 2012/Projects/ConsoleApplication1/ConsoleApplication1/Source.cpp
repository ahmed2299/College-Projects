#include "LinkedList.cpp"
#include <iostream>
#include<list>
 
using namespace std;
 
int main()
{
	LinkedList<float>li;
	li.Append(5);
	li.Append(4);
	li.Append(5);
	li.Append(2);
	li.Append(1);
	li.Append(0);
	li.display();
	cout<<"............................\n";
	li.shift();
	li.display();
// L.clear();
	//system("pause");
	return 0;
}