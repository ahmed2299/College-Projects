#include <iostream>

using namespace std;
const long long N = 1e4 + 5, M = 2e4 + 5, OO = 0x3f3f3f3f;
const double eps = 1e-6;
int arr[N];
char ch[N];
char c;
int c1;
char c2;
bool found;
int main(){

  while(c=getchar()){
    ch[c1]=c;
    
    if(c=='\n')
        break;
	c1++;
  }
  
  for(int i=0;i<c1;i++){
    if(c2==ch[i]){
		ch[c2]-=1;
		found=1;
		if(ch[c2]==0){
			c2++;
			found=0;
			continue;
		}
	}
	if(i==c1-1&&found==0){
		cout<<"NO"<<endl;
		return 0;
	}
	else{
		found=0;
		continue;
	}
	
  }
  
    cout<<"YES"<<endl;
  return 0;
}