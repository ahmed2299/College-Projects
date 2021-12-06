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

Client::Client(void)
{
	struct Login{
		string userName;
		string password;
	}user;
	user.userName="";
	user.password="";
}
void Client::login(){
	system("cls");
	system("colour A");
	struct Login{
		string userName;
		string password;
	}user;
	fstream login;
	string name,pass;
	bool flag=0;
	cout << "\n\n\n\t\t\t Enter your Username       : ";
	cin>>name;
	cout << "\n\n\n\t\t\t Enter your password : ";
	HiddenPassword(pass);
	login.open("client_data.txt");
	while (!login.eof())
	{
		login>>user.userName>>user.password;
		if(user.userName==name&&user.password==pass){
			 flag=1;
			cout << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl;
			cout << "\n\n\n\t\t\t you have logged in succesfully" << endl;
			system("cls");
			buyItem();
			
		}
		if(flag)
		break;
	}
	login.close();
		if(!flag){
		cout << "\n\n\n\t\t\tError Data Entered !" << endl;
		system("cls");
	}
}

void Client::registeration(){
	system("cls");
	system("colour A");
	struct Login{
		string userName;
		string password;
	}user;
	fstream login;
	cout << "\n\n			Enter your information \n\n			" << endl;
	int num_of_items=0;
	login<<num_of_items<<endl;
	cin.ignore(1000, '\n');
	cout<<"\t\t\n\n Enter the username you want to register : ";
	getline(cin,user.userName);
	cout<<"\t\t\n\n Enter your password : ";
	getline(cin,user.password);
	login.open("client_data.txt",ios::app);
	login<<"\n"<<endl;
	login<<user.userName<<endl;
	login<<user.password<<endl;
	login.close();
	system("cls");
}
void Client::buyItem(){
	system("color A");
	fstream item_data;
	fstream temp;
	struct items_data
	{
		string brand;
		string itemType;
		string itemColour;
		int price;
	}item;
	string type_of_item;
	string brand_name;
	string colour;
	int price;
	cin.ignore(1000, '\n');
	cout<<"\t\t\n\nEnter the brand name :   ";
	cin>>brand_name;
	cin.ignore(1000, '\n');
	cout<<"\t\t\n\nEnter the item name :   ";
	cin>>type_of_item;
	cout<<"\t\t\n\nEnter the item colour :   ";
	cin>>colour;
	cin.ignore(1000, '\n');
	
	cout<<"\t\t\n\nEnter the price   :   ";
	cin>>price;
	system("cls");
	map<pair<string,string>,pair<string,int>>search;
	map<pair<string,string>,pair<string,int>>::iterator it;
	search.insert(make_pair(make_pair(brand_name,type_of_item),make_pair(colour,price)));
	it=search.begin();
	temp.open("delete.txt",ios::out|ios::app);
	item_data.open("items.txt",ios::in|ios::out);
	while(!item_data.eof()){
		item_data>>item.brand>>item.itemType>>item.itemColour>>item.price;
		if(item.brand==".."){
			break;
		}
		if((it->first).first==item.brand&&(it->first).second==item.itemType&&(it->second).first==item.itemColour&&(it->second).second==item.price){
			//temp<<endl<<temp<<endl<<temp<<endl<<temp<<endl;
		}
		else {
			temp<<item.brand<<endl;
			temp<<item.itemType<<endl;
			temp<<item.itemColour<<endl;
			temp<<item.price<<endl;
			
		}
	}
	item_data.close();
	temp.close();
	remove("items.txt");
	rename("delete.txt","items.txt");
}

void Client::clientFunctionalitiesScreen(){
	mainScreen();
	int number;
	cin>>number;
	while(true){
		if(number==1) login();
		else if(number==2) registeration();
	else {
		break;
		system("cls");
	}
	mainScreen();
	cin>>number;
	}
}
string Client:: HiddenPassword(string &pass){
	char c;
	c = _getch();                     //for hiding the password
	while (c != 13) {                 // 13 in ascii 'Enter'
		pass += c;
		if (c == 8) {                 //8 in asci 'Backspace'
			cout << "\b \b";
			pass.erase(pass.size() - 2);
		}
		else
			cout << "*";
		c = _getch();
	}
	return pass;
}
void Client::mainScreen(){
	system("colour A");
	system("cls");
	int number;
	cout << endl << endl << endl << endl << endl << endl;
	cout << "\t\t        *****************************" << endl;
	cout << "\t\t        *****************************" << endl;
	cout << "\t\t        ***                       ***" << endl;
	cout << "\t\t        ***	  1.login	  ***" << endl;
	cout << "\t\t        ***	  2.register      ***" << endl;
	       cout << "\t\t ***	  3.close          ***"<<endl;
	cout << "\t\t        *****************************" << endl;
	cout << "\t\t        *****************************" << endl;
	cout << "\t\t\t Choose : ";
	
}
Client::~Client(void)
{
}
