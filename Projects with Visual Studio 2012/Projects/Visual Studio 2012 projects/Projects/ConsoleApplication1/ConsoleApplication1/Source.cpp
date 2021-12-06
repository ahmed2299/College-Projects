#include <iostream>
#include <string>
#include <algorithm>
using namespace std;
int main()
{
   int n,i;
   int arr[1000];
   cin>>n;
   int even=0,odd=0,indexeven[1000],indexodd[1000];
   bool iseven=false;
   for( i=0;i<n;i++)
   {
	   cin>>arr[i];
	   if(arr[i]%2==0)
	   {
        even++;
		indexeven[i]=arr[i];
	   }
	   else{
		   odd++;
		   indexodd[i]=arr[i];
	   }
	   if(odd<even)
	   {
		   cout<<indexodd[i]+1<<endl;
	   }
	   else
		   cout<<indexeven[i]+1<<endl;
   }
   
}
