#include "Queues.h"
#include <iostream>
#include <assert.h>
template<class T>
queues<T>::queues()
{
	elements=0;
	front=0;
	size=10;
	arr=new T[size];
}
template<class T>
void queues<T>::expand(){
	size=size*2;
	T *arr2=new T[size];
	for(int i=0;i<elements;++i){
			arr2[i]=arr[i];
		}
	delete []arr;
		arr=arr2;
}
template<class T>
bool queues<T>::empty(){
	if(elements==0)
		return 1;
		return 0;
	
}
template<class T>
void queues<T>::push(T data){
	if(elements==size) expand();
		arr[elements]=data;
		elements++;
	
	
}
template<class T>
void queues<T>::pop(){
	assert(!empty());{
	elements--;
	}
}
/*int back(){
	return arr[elements-1];
}*/
template<class T>
T queues<T>::ffront(){
	assert(!empty());
	return arr[front];
}
template<class T>
queues<T>::~queues(void)
{
	delete[] arr;
}
