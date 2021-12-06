#include<iostream>
using namespace std;
void selection_sort(int arr[],int n)
{
	int temp;
	for(int i=0;i<n-1;i++)
	{
    int min=i;
		for(int j=n-1;j>0;j--)
		{
        if(arr[j]>arr[min])
			min=j;
		{
			temp=arr[i];
			arr[i]=arr[min];
			arr[min]=temp;
		}
		}
		
}
}
int main()
{
	int arr[]={20,50,10,70};
	selection_sort(arr,4);
	for(int i=0;i<4;i++)
	{
		cout<<arr[i]<<"  ";
	}
}


