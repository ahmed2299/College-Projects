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
	Node<T>*newnode=new Node<T>;
	int c=0;
	for(int i=0;i<count;i++){
		cout<<tmp->value<<endl;
		tmp=tmp->next;
	}
	/*for(int i=1;i<count;i+=2){
		tmp=tmp->next;
		cout<<"List 2 is: "<<tmp->value;
	}*/
	
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
 void LinkedList<T>::alternatingSplit(){
	Node<T>*tmp=head;
	Node<T>*newnode=new Node<T>;
	int c=0;
	while(tmp->next!=0){
		cout<<tmp->value<<endl;
		tmp=tmp->next;
		if(tmp==tail){
		   break;
		}
		else
			tmp=tmp->next;
	}
	tmp=head;
	while(tmp->next!=0){
		tmp=tmp->next;
		cout<<tmp->value<<endl;
		
		if(tmp->next==0)
			break;
		else tmp=tmp->next;
	
 }
 }
 template<class T>
LinkedList<T>::~LinkedList(void){

}