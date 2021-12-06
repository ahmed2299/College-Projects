#include "LinkedList.h"
#include <assert.h>
#include<iostream>
using namespace std;
template<class T>
Node<T>::Node(){
	value=0;
    next=0;
}
template<class T>
Node<T>::Node(T val){
	value=val;
    next=0;
}
template<class T>
LinkedList<T>::LinkedList(){
	head=tail=0;
	count=0;

}
template<class T>
int LinkedList<T>::Length(){
	return count;
}
template<class T>
void LinkedList<T>::Append(T val){
	Node<T> *newnode=new Node<T>(val);
	if(head==0){
		head=tail=newnode;
	}
	else{
		tail->next=newnode;
		tail=newnode;
	}
	count++;
}
template<class T>
void LinkedList<T>::InsertAt(int pos,T val){
	assert(pos<count);
	Node<T>*newnode=new Node<T>(val);
	Node<T>*tmp=head;
	if(pos==0){
		newnode->next=head;
		head=newnode;
	}
	else if(pos<count&&pos>0){
		for(int i=0;i<pos-1;i++)
			tmp=tmp->next;

		newnode->next=tmp->next;
		tmp->next=newnode;
	}
	else if(pos==count){
		tail->next=newnode;
		tail=newnode;
		}
	count++;
}
template<class T>
void LinkedList<T>::DeleteAt(int pos){
	assert(pos>=0&&pos<count);
	Node<T>*tmp=head;
	if(pos==0){
		head=head->next;
		Node<T>*del=tmp;
		delete tmp;
	}
	else {
		for(int i=0;i<pos-1;i++)
			tmp=tmp->next;
		Node<T> *del=tmp->next;
		tmp->next=del->next;
		delete del;
		if(pos==count-1)
			tail=tmp;
	}
	count--;
}
template<class T>
void LinkedList<T>:: display(){
	Node<T>*tmp=head;
	int c=0;
	while(tmp!=NULL&&c<count){
		cout<<tmp->value<<endl;
		tmp=tmp->next;
		c++;
	}
}
template<class T>
void LinkedList<T>:: moveNode(T val,int pos){
	assert(pos<count);
	Node<T> *newnode=new Node<T>(val);
	Node<T>*tmp=head;
	int c=0;
	while(tmp!=0&&val!=tmp->value){
		tmp=tmp->next;
		c++;
	}
	DeleteAt(c);
	InsertAt(pos,val);
}
template<class T>
 T LinkedList<T>::At(int pos){
	assert(pos>=0&&pos<count);
	Node*tmp=head;
	for(int i=0;i<pos;i++)
		tmp=tmp->next;
	return tmp->value;
}
 template<class T>
  void LinkedList<T>::shift(){
	  Node<T>*tmp=head;
	  Node<T>*tmp2=tail;
	  for(int i=0;i<count-2;i++)
		  tmp=tmp->next;
	  tail=tmp;
	  tail->next=0;
	  tmp2->next=head;
	  head=tmp2;
	 
 }
 template<class T>
 bool LinkedList<T>::hasNext(T val){
	 Node<T>*tmp=head;
	 for(int i=0;i<count;i++){
		 if(val==tmp->value)
			 break;
		 tmp=tmp->next;

	 }
	 if(tmp->next==0) return 0;
	 else{
	 return 1;
	 }
 }
 template<class T>
 void LinkedList<T>::replaceAll(T val,T val2){
	 Node<T>*tmp=head;
	 for(int i=0;i<count;i++){
		 if(tmp->value==val)
			 tmp->value=val2;
		 tmp=tmp->next;
	 }
 }
 template<class T> 
 T LinkedList<T>::lastOccurence(T val){
	 Node<T>*tmp=head;
	 T cont;
	 for(int i=0;i<count;i++){
		 if(tmp->value==val){
			 cont=i+1;
		 }
		 tmp=tmp->next;
	 }
	 return cont;
 }
 template<class T>
 void LinkedList<T>::shiftRight(int pos){
	 Node<T>* tmp=head;
	 Node<T>* tmp2=tail;
	 for(int i=0;i<count-pos-1;i++)
		 tmp=tmp->next;
	 tail=tmp;
	 tail=0;
	 for(int i=count-pos-1;i<count;i++){
		 tmp=tmp->next;
		 if(i==count-pos-1) node*tmpHead=tmp;
		 if(i==count-1){
			 tmp->next=head;
			 head=tmpHead;
		 }
	 }

 }
 template<class T>
LinkedList<T>::~LinkedList(void){

}