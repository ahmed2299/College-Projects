#include "stacks.h"
#include<assert.h>

bool stacks::empty(){
	if(numOfelements==0)
		return 1;
	else
		return 0;
}
void stacks::expand(){
	if(numOfelements==size){
		size=size*2;
		int *arr2=new int [size];
		for(int i=0;i<numOfelements;++i)
			arr2[i]=arr[i];
		//size=size*2;
		arr=arr2;
	}
}
stacks::stacks()
{
	size=10;
	numOfelements=0;
	arr=new int[size];
}
stacks::stacks(int s)
{
	numOfelements=0;
	size=s;
	arr=new int[size];
}

void stacks::push(int data)
{
	if(numOfelements==size)
		expand();
	arr[numOfelements]=data;
	numOfelements++;
}
void stacks::pop(){
	assert(!empty());
		numOfelements--;
	
	
}
int stacks::top(){
	assert(!empty());
	return arr[numOfelements-1];
}

stacks::~stacks(void)
{
}
