#include "BSTree.h"
#include <iostream>
#include <assert.h>
using namespace std;
template<class T>
Node<T>::Node(){
	right=left=0;
}
template<class T>
Node<T>::Node(T val){
	right=left=0;
	value=val;
}	
template<class T>
BSTree<T>::BSTree(){
	root=0;
	arr=new T [size];
}

template<class T>
void BSTree<T>::balancedTree(int* arr){
	int sz=size;
	Node<T> start=0,end=sz-1;
	Node<T> middle=(start+end)/2;
	Node<T> middleRight=middle,middleLeft=middle;
	Node<T>* newnode=new Node<T>(middle);
	Node<T>*tmp=root;
	if(root==0)  root=newnode;
	else tmp=newnode;
	while(true){
		middleLeft=(middleLeft-1)/2;
		tmp->left=middleLeft;
		if(middleLeft==0) break;
		middleRight=(middleRight+1+end)/2;
		tmp->right=middleRight;
		if(middleRight==sz-1) break;
	}
	/*if(order==1){
		inOrder(root);
	}
	else if(order==2){
		preOrder(root);
	}
	else if(order==3){
		postOrder(root);
	}*/
}
template<class T>
Node<T>* BSTree<T>::findNode(T val){
	Node<T>*tmp=root;
	while(tmp!=0&&tmp->value!=val){
		if(tmp->value>val) tmp=tmp->left;
		else tmp=tmp->right;
	}
	return tmp;
}
template<class T>
bool BSTree<T>:: contains(T val){
	Node<T> *tmp=findNode(val);
	if(tmp!=0) return 1;
	else return 0;
}
template<class T>
void BSTree<T>::insert(T val){
	assert(contains(val)==0);
	Node<T> *tmp=root;
	Node<T> *newnode=new Node<T>(val);
	if(root==0) root=newnode;
	else{
		while(true){
			if(tmp->value>val){
				if(tmp->left==0){
					tmp->left=newnode;
					break;
				}
				else{
					tmp=tmp->left;
				}
			}
			else{
				if(tmp->right==0){
					tmp->right=newnode;
					break;
				}
				else{
					tmp=tmp->right;
				}
			}
		}
	}
}
template<class T>
void BSTree<T>::traverse(int order){
	if(order==1){
		inOrder(root);
	}
	if(order==2){
		preOrder(root);
	}
	if(order==3){
		postOrder(root);
	}
}
template<class T>
void BSTree<T>::inOrder(Node<T> *start){
	if(start!=0){
		inOrder(start->left);
		cout<<start->value<<endl;
		inOrder(start->right);
	}
}
template<class T>
void BSTree<T>::preOrder(Node<T> *start){
	if(start!=0){
		cout<<start->value<<endl;
		preOrder(start->left);
		preOrder(start->right);
	}
}
template<class T>
void BSTree<T>::postOrder(Node<T> *start){
	if(start!=0){
		postOrder(start->left);
		postOrder(start->right);
		cout<<start->value<<endl;
	}
}
template<class T>
Node<T>* BSTree<T>::findParent(T val){
	Node<T> *tmp=root;
	Node<T> *parent=root;
	Node<T> *newnode=new Node<T>(val);
	if(root==0) return 0;
	else{
		while(true){
			if(tmp->value>val){
				tmp=tmp->left;
				if(tmp->value==val){
					break;
				}
				else{
					parent=parent->left;
				}
			}
			else{
				tmp=tmp->right;
				if(tmp->value==val){
					break;
				}
				else{
					parent=parent->right;
				}
			}
		}
	}
	return parent;
}
template<class T>
void BSTree<T>::remove(T val){
	Node<T> *n=findNode(val);
	
	if(n->left==0&&n->right==0){
		Node<T> *parent=findParent(val);
		if(parent->value>n->value){
			parent->left=n->left;
		}
		else{
			parent->right=n->right;
		}
		delete n;	
	}
	else if(n->left==0&&n->right!=0){
		Node<T> *parent=findParent(val);
			if(parent->value>n->value)
				parent->left=n->right;
			else 
				parent->right=n->right;
			delete n;
		}
	else if(n->left!=0&&n->right==0){
		Node<T> *parent=findParent(val);
			if(parent->value>n->value)
				parent->left=n->left;
			else 
				parent->right=n->left;
			delete n;
		}
	
	else{
		Node<T> *mn=findMin(n->right);
		Node<T> *parent=findParent(mn->value);
		n->value=mn->value;
		if(parent->value>mn->value)
			parent->left=mn->right;
		else parent->right=mn->right;
		delete mn;
	}
}
template<class T>
Node<T>* BSTree<T>::findMin(Node<T>* start)
{
	Node<T>* minNode=start;
	while(minNode->left!=NULL)
		minNode=minNode->left;
	return minNode;
}
template<class T>
BSTree<T>::~BSTree(void)
{
}