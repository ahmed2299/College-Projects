#include "arraylist.h"
#include <assert.h>
#include<iostream>
using namespace std;
template<class T>
arraylist<T>::arraylist()
{
	size=10;
	count=0;
	arr=new T[size];

}
template<class T>
void arraylist<T>::append(T val){
	if(count==size){
		expand();
	}
	else{
	 arr[count]=val;
	count++;
	}
}
template<class T>
void arraylist<T>::display(){
	for(int i=0;i<count;i++)
		cout<<arr[i]<<" ";
	cout<<endl;
}
template<class T>
void arraylist<T>::removeAll(T val){
	T x;
	for(int i=0;i<count;i++){
		if(arr[i]==val){
			for(int j=i;j<count-1;j++)
			arr[j]=arr[j+1];
			count--;
		}
}
}
template<class T>
void expand(){
	T *arr2=new arr[size*2];
	for(int i=0;i<size;i++){
		arr2[i]=arr[i];
	}
	arr=arr2;
	delete []arr2;
}
template<class T>
arraylist<T>::~arraylist(void)
{
}
