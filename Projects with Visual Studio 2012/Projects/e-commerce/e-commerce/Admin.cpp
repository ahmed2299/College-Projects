#include "Admin.h"
#include<iostream>           
#include<string>               
#include<windows.h>					 
#include<fstream>					 
#include<conio.h>                    
#include<ctime>                      
#include <mmsystem.h>
#include<map>
#include<math.h>
#include<algorithm>

#pragma comment(lib, "winmm.lib")
#include<vector>
using namespace  std;

Admin::Admin(void)
{
	userName="";
	password="";
}
void Admin::login(){
	system("cls");
	admin.open("admin_login.txt");
	while(!admin.eof()){
		getline(admin,userName);
		getline(admin,password);
	}
	admin.close();
	cout << "\n\n\n\t\t\t Enter your Username       : ";
	cin>>user;
	cout << "\n\n\n\t\t\t Enter your password : ";
	HiddenPassword(pass);
	bool flag=0;
	system("cls");
	admin.open("admin_login.txt");
	while (!admin.eof())
	{
		if(userName==user&&password==pass){
			 flag=1;
			cout << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl;
			cout << "\n\n\n\t\t\t you have logged in succesfully" << endl;
			system("cls");
			adminFunctionalityScreen();
			break;
		}
	}
	admin.close();
	if(!flag){
		cout << "\n\n\n\t\t\tError Data Entered !" << endl;
	}
}
void Admin:: update(){
	system("color B");
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
	cin.ignore(1000, '\n');
	cout<<"\t\t\n\nEnter the brand name :   ";
	cin>>brand_name;
	cin.ignore(1000, '\n');
	cout<<"\t\t\n\nEnter the item name :   ";
	cin>>type_of_item;
	cin.ignore(1000, '\n');
	int price;
	cout<<"\t\t\n\nEnter the price to be Updated  :   ";
	cin>>price;
	int newPrice;
	system("cls");
	cout<<"\t\t\n\nEnter the new price you want to enter :     ";
	Sleep(2000);
	system("cls");
	cin>>newPrice;
	map<pair<string,string>,int>search;
	map<pair<string,string>,int>::iterator it;
	search.insert(make_pair(make_pair(brand_name,type_of_item),price));
	it=search.begin();
	temp.open("update.txt",ios::out|ios::app);
	item_data.open("items.txt",ios::in|ios::out);
	while(!item_data.eof()){
		item_data>>item.brand>>item.itemType>>item.itemColour>>item.price;
		if(item.brand==".."){
			break;
		}
		if((it->first).first==item.brand&&(it->first).second==item.itemType&&it->second==item.price){
			item.price=newPrice;
			temp<<item.brand<<endl;
			temp<<item.itemType<<endl;
			temp<<item.itemColour<<endl;
			temp<<item.price<<endl;
		
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
	rename("update.txt","items.txt");
	remove("update.txt");
	
}
void Admin::mainScreen(){
	system("color A");    
	cout << endl << endl << endl << endl << endl << endl;
	cout << "\t\t        *****************************" << endl;
	cout << "\t\t        *****************************" << endl;
	cout << "\t\t        ***                       ***" << endl;
	cout << "\t\t        ***	  1.Admin	  ***" << endl;
	cout << "\t\t        ***	  2.Client	  ***" << endl;
	cout << "\t\t        ***	  3.Close         ***" << endl;
	cout << "\t\t        *****************************" << endl;
	cout << "\t\t        *****************************" << endl;
	cout << "\t\t\t Choose : ";
	//system("cls");
}

void Admin::addItem(){
	fstream item_data;
	struct items_data
	{
		string brand;
		string itemType;
		string itemColour;
		int price;
	}item;
	int num_of_items=0;
	string item_name;
	system("color A");
	system("cls");
	cout << "\n\n			Enter your information \n\n			" << endl;
	item_data<<num_of_items<<endl;
	cin.ignore(1000, '\n');
	cout<<"\t\t\n\nEnter the brand name  :";
		getline(cin,item.brand);
		cout<<"\t\t\n\nEnter the type of the item  :";
		getline(cin,item.itemType);
		cout<<"\t\t\n\n Enter the colour of the item  :";
		getline(cin,item.itemColour);
		cout<<"\t\t\n\nEnter the price of the item  :";
		cin>>item.price;
	
		item_data.open("items.txt",ios::app);
		
			item_data<<item.brand<<endl;
			item_data<<item.itemType<<endl;
			item_data<<item.itemColour<<endl;
			item_data<<item.price<<endl;
		
		item_data.close();
		system("cls");
}
string Admin:: HiddenPassword(string &pass){
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
void Admin::adminFunctionalityScreen(){
	system("colour B");
	int number;
	cout << endl << endl << endl << endl << endl << endl;
	cout << "\t\t        *****************************" << endl;
	cout << "\t\t        *****************************" << endl;
	cout << "\t\t        ***                       ***" << endl;
	cout << "\t\t        ***	  1.Add new item or brand	  " << endl;
	cout << "\t\t        ***	  2.Update price data          " << endl;
	cout << "\t\t        ***	  3.delete item         " << endl;
    cout << "\t\t        ***      4.display brand sorted                "<<endl;
	cout << "\t\t        ***      5.close                "<<endl;
	cout << "\t\t        *****************************" << endl;
	cout << "\t\t        *****************************" << endl;
	cout << "\t\t\t Choose : ";
	cin>>number;
	system("cls");
	while(true){
	if(number==1){
		addItem();
		break;
	}
	else if(number==2){
		update();
		break;
	}
	else if(number==3){ deleteData();
	break;
	}
	else if(number==4){ display_brand_sorted();
	break;
	}
	else break;
	}
}
void Admin::deleteData(){
	system("color B");
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
	cin.ignore(1000, '\n');
	cout<<"\t\t\n\nEnter the brand name :   ";
	cin>>brand_name;
	cin.ignore(1000, '\n');
	cout<<"\t\t\n\nEnter the item name :   ";
	cin>>type_of_item;
	cin.ignore(1000, '\n');
	int price;
	cout<<"\t\t\n\nEnter the price   :   ";
	cin>>price;
	system("cls");
	map<pair<string,string>,int>search;
	map<pair<string,string>,int>::iterator it;
	search.insert(make_pair(make_pair(brand_name,type_of_item),price));
	it=search.begin();
	temp.open("delete.txt",ios::out|ios::app);
	item_data.open("items.txt",ios::in|ios::out);
	while(!item_data.eof()){
		item_data>>item.brand>>item.itemType>>item.itemColour>>item.price;
		if(item.brand==".."){
			break;
		}
		if((it->first).first==item.brand&&(it->first).second==item.itemType&&it->second==item.price){
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
	//remove("delete.txt");
}
void Admin::display_brand_sorted(){
	struct  data{
		string brand[100];
		string type[100];
		string colour[100];
		int price[100];
	}item;
	vector<data> vec;
	string brand_name;
	cout<<"Enter the brand to be sorted: ";
	cin>>brand_name;
	int c=0;
	item_data.open("items.txt",ios::in|ios::out);
	while(!item_data.eof()){
		item_data>>item.brand[c]>>item.type[c]>>item.colour[c]>>item.price[c];
		if(brand_name==item.brand[c]) vec.push_back(item);
		c++;
	}
	item_data.close();
	for(int i=0;i<vec.size();i++){
		for(int j=i+1;j<vec.size();j++){
			if(item.price[j]<item.price[i]){ 
				swap(item.brand[i],item.brand[j]);
				swap(item.type[i],item.type[j]);
				swap(item.colour[i],item.colour[j]);
				swap(item.price[i],item.price[j]);

			}
		}
	}
	item_data.open("display.txt",ios::app);
	for(int i=0;i<vec.size();i++){
		item_data<<item.brand[i]<<endl;
		item_data<<item.type[i]<<endl;
		item_data<<item.colour[i]<<endl;
		item_data<<item.price[i]<<endl;
	}
	item_data.close();
}

	
Admin::~Admin(void)
{
}
