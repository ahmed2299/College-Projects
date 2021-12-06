#pragma once

template<class T>
  class Node{
	  public:
	  Node<T> *left,*right;
	  T  value;
	  Node();
	  Node(T val);
  
  };
  template<class T>
   class BSTree{
	  Node<T> *root;
	  T *arr;
	  int size;
	  public:
	  BSTree();
	 void balancedTree(int *arr);
     void insert(T val);
	 void traverse(int order);
	 void inOrder(Node<T>*start);
	 void preOrder(Node<T>*start);
	 void postOrder(Node<T>*start);
	 bool contains(T val);
	 Node<T>* findNode(T val);
	 Node<T>* findParent(T val);
	 void remove(T val);
	 Node<T>* findMin(Node<T>* start);
	~BSTree(void);
};
