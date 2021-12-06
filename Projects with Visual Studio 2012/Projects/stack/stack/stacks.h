#pragma once
class stacks
{
	int size;
	int *arr;
	int numOfelements;
public:
	stacks();
	stacks(int s);
	void push(int data);
	void pop();
	int top();
	void expand();
	bool empty();


	~stacks(void);
};

