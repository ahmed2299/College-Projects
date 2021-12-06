#pragma once
template<class T>
class arraylist
{
	T *arr;
	T value;
	int count;
	int size;
public:
	arraylist();
	void append(T val);
	void display();
	void removeAll(T val);
	void expand();
	~arraylist(void);
};

