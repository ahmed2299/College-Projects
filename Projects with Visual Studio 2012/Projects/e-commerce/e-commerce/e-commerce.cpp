#include<iostream>           
#include<string>               
#include<windows.h>					 
#include<fstream>					 
#include<conio.h>                    
#include<ctime>                         
#include <mmsystem.h>
#pragma comment(lib, "winmm.lib") 
#include "Admin.h"
#include "Client.h"
using namespace std;
	int choose;
int main()
{
	Admin admin;
	Client client;
	/*admin.ecommerceScreen();*/
	while (true)
	{
		admin.mainScreen();
		
		cin>>choose;
		if(choose==1)	admin.login();
		else if(choose==2) client.clientFunctionalitiesScreen();
		else break;
	}
	
}

