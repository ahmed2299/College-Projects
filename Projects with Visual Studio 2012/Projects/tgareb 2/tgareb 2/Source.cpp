#include <iostream>
#include <cstdio>

#include <string>
#include <cstring>
#include <sstream>

#include <vector>
#include <stack>
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
#include<stdio.h>
#include <cmath>
#include <cstdlib>
#include <cctype>
#include <cstdlib>
#include <ctime>
#include<unordered_map>
#include<list>
using namespace std;
#define ll long long 
//const long long N = 2e6 + 5, M = 2e4 + 5, OO = 0x3f3f3f3f;
const double eps = 1e-6;

int n,m,c1,c2;

int main()
{
   cin>>n;
   int a[10000];
   for(int i=0;i<n;i++) cin>>a[i];
   cin>>m;
   int queries[10000];
   for(int i=0;i<m;i++) cin>>queries[i];
   for(int i=0;i<n;i++){
    for(int j=0;j<m;j++){
         if(queries[j]==a[i]&&i==0){
            c1++;
            break;
        }
		else if(queries[j]==a[i]&&i>0){
			c1+=2;
            break;
		}
    }
   }
   for(int i=n-1;i>=0;i--){
    for(int j=0;j<m;j++){
        if(queries[j]==a[i]&&i==0){
            c2++;
            break;
        }
		else if(queries[j]==a[i]&&i>0){
			c2+=2;
            break;
		}
    }
   }
   cout<<c1<<" "<<c2<<endl;
}

