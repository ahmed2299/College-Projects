#pragma once
template<class T>
class queues
{
	int elements;
	int size;
	T *arr;
	int front;
	int elemnts ;
public:
	queues();
	void push(T);
	void pop();
	bool empty();
	void expand();
	T ffront();
	int back();
	~queues();
};

