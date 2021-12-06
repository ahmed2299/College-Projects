#include "LinkedList.cpp"
#include <iostream>

 
using namespace std;
 
int main()
{
	LinkedList<float> L;
	L.Append(9);
	L.Append(10);
	L.Append(11);   
	L.Append(12);
	//L.display();
	L.alternatingSplit();
    //L.clear();
    //system("pause");
	return 0;
}