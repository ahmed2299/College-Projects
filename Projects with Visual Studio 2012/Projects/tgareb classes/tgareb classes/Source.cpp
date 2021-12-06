#include"student.h"
#include<iostream>
#include<vector>
#include<stack>
#include<string>
using namespace std;
int total;
int main(){
	stack <int>st;
	string s;
	cin>>s;
	for(int i=0;i<s.size();i++){
		if(s[i]=='(')
			st.push(1);
		
		else if(s[i]==')'){
			if(!st.empty())
				st.pop();
			else{
				cout<<"unbalanced "<<endl;
				return 0;
			}
		}
		
	}
	if(st.empty()){
		cout<<"yes right "<<endl;
	}
	else
		cout<<"unbalaced tooo "<<endl;
	
	return 0;
}