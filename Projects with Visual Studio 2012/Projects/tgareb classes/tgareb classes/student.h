#pragma once
class student
{
	char name[100];
	int numOfStudents;
	int counter;
	int arr[100];
	int total;
public:
	student();
	void readData();
	int Display();
	~student(void);
};

