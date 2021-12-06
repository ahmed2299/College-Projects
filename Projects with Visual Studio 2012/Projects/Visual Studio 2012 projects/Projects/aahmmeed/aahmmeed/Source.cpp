#include<iostream>
using namespace std;
void main()
{
	int arr[3]={10,9,8};
	int min=arr[0];
	int temp;
	for(int i=0;i<3;i++)
	{
		for(int j=i;j<3;j++)
		{
			min=j;
			if(arr[min]>arr[j])
			{
				arr[j]=arr[min];
				temp=arr[j];
				arr[min]=temp;
			}
			
		}
		cout<<arr[min];
	}

}