#include<iostream>
#include "BST.cpp"

using namespace std;

int main()
{
	BST<int> B;
	B.insert(63);
	B.insert(41);
	B.insert(74);
	B.insert(16);
	B.insert(53);
	B.insert(65);
	B.insert(25);
	B.insert(46);
	B.insert(55);
	B.insert(64);
	B.insert(70);
	B.traverse(1);
	cout<<">>>>>>>>>>>>>>>>"<<endl;
	//B.remove(41);
	B.traverse(2);
	cout<<">>>>>>>>>>>>>>>>"<<endl;
	B.traverse(3);
	/*cout<<"enter size of array"<<endl;
	int size;
	cin>>size;
	int *arr=new int [size];
	for(int i=0;i<size;i++){
		cin>>arr[i];
	}
	B.balancedTree(arr);
	B.traverse(1);*/
	return 0;
}