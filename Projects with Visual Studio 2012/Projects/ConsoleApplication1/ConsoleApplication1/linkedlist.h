#pragma once
#pragma once
template<class T>
class Node 
{
	public:
	Node<T>* next;
	 T value;
 
	Node<T>();
	Node<T>(T val);
};

template<class T> 
class LinkedList
{
	int count;
	Node<T> *head;
	Node<T> *tail;
public:
	LinkedList<T>();
	LinkedList<T>(T val);
	int Length();
	T At(int pos);
	void InsertAt(int pos,T val);
	void Append(T val);
	void DeleteAt(int);
	void moveNode(T,int);
	void display();
	void shift();
	bool hasNext(T val);
	void replaceAll(T val,T val2);
	void shiftRight(int pos);
	T lastOccurence(T val);
	//void clear();
	~LinkedList(void);
};

