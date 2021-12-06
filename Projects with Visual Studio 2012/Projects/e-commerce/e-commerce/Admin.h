#pragma once
#include<iostream>
#include<string>
#include<fstream>
#include<vector>
using namespace std;
//class laptop{
//public:
//	string type;
//	string color;
//	int price;
//}p;

class Admin
{
public:
	string userName;
	string password;
	string user;
	string pass;
	fstream admin;
	fstream item_data;
	fstream update_data;
	Admin(void);
	void login();
	//void regster();
	void mainScreen();
	void display_brand_sorted();
	void addItem();
	void update();
	string HiddenPassword(string &pass);
	void adminFunctionalityScreen();
	void deleteData();
	void ecommerceScreen();
	~Admin(void);
};

