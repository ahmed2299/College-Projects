#include <iostream>
#include "students.h"
#include <stack>
#include <math.h>
#include <cstdio>
#include <string>
#include <cstring>
#include <sstream>
#include <vector>
#include <queue>
#include <deque>
#include <list>
#include <map>
#include <set>
#include <algorithm>
#include <bitset>
#include <functional>
#include <numeric>
#include <utility>
#include <iomanip>
#include <cmath>
#include <cstdlib>
#include <cctype>
#include <cstdlib>
#include <ctime>
using namespace std;
int main()
{
	students st;
	vector<students>studentName;
	
	cout<<"enter the number of students you want: ";
	int num;
	cin>>num;
	float mx_is=INT_MIN,mx_cs=INT_MIN,mx_sc=INT_MIN,mx_csys=INT_MIN;
	int c_is=-1,c_cs=-1,c_sc=-1,c_csys=-1;

	for(int i=0;i<num;i++){
		st.input();
		studentName.push_back(st);
	}
	for(int i=0;i<num;i++){
		if(studentName[i].getDepartment()=="IS"&&studentName[i].getGpa()>mx_is){
			mx_is=max(st.getGpa(),mx_is);
			c_is=i;
		}
		else if(studentName[i].getDepartment()=="CS"&&studentName[i].getGpa()>mx_cs){
			mx_cs=max(st.getGpa(),mx_cs);
			c_cs=i;
		}
		else if(studentName[i].getDepartment()=="SC"&&studentName[i].getGpa()>mx_sc){
			mx_sc=max(st.getGpa(),mx_sc);
			c_sc=i;
		}
		else if(studentName[i].getDepartment()=="CSYS"&&studentName[i].getGpa()>mx_csys){
			mx_csys=max(st.getGpa(),mx_csys);
			c_csys=i;
		}
	}
	cout<<"results: "<<endl;
	if(c_is==-1){
			cout<<"IS: "<<"No students found"<<endl;
		}
		else cout<<"IS: "<<studentName[c_is].Name()<<endl;
		if(c_cs==-1){
			cout<<"CS: "<<"No students found"<<endl;
		}
		else cout<<"CS: "<<studentName[c_cs].Name()<<endl;
		if(c_sc==-1){
			cout<<"SC: "<<"No students found"<<endl;
		}
		else cout<<"SC: "<<studentName[c_sc].Name()<<endl;
		if(c_csys==-1){
			cout<<"CSYS: "<<"No students found"<<endl;
		}
		else cout<<"CSYS: "<<studentName[c_csys].Name()<<endl;
		//else cout<<studentName[i].getDepartment()<<" :No students found"<<endl;

	return 0;
}