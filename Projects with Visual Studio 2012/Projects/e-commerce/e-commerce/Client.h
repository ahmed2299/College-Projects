#pragma once
#include "Client.h"
#include<iostream>           
#include<string>               
#include<windows.h>					 
#include<fstream>					 
#include<conio.h>                    
#include<ctime>                      
#include <mmsystem.h>
#include<map>
#pragma comment(lib, "winmm.lib")
using namespace  std;
class Client
{
public:


	void login();
	void registeration();
	void buyItem();
	void clientFunctionalitiesScreen();
	string  HiddenPassword(string &pass);
	void mainScreen();
	Client(void);
	~Client(void);
};

