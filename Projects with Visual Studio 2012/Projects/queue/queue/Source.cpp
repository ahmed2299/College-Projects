#include"queues.h"
#include"queues.cpp"
#include<iostream>
using namespace std;
int main(){
	queues<double> q;
	q.push(50.5);
	q.push(20);
	q.push(20);
	q.push(20);
	q.push(20);
	q.push(20);
	q.push(20);
	q.push(20);
	q.push(20);
	q.push(20);
	q.push(20);
	q.push(20);
	q.push(20);
	q.push(20);
	q.push(20);
	q.push(20);
	q.push(20);
	q.push(20);
	q.push(20);
	q.push(20);
	q.pop();
	cout<<q.ffront()<<endl;
	system("pause");
	return 0;
}