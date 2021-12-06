#pragma once
#include<string>
using namespace std;

class students
{
	int id;
	string name;
	float gpa;
	string departmentName;

public:
	students();
	students(int idx, string namex, float gpax, string depx);
	void displayName();
	float getGpa();
	string getDepartment();
	void input();
	string Name();

	~students(void);
};