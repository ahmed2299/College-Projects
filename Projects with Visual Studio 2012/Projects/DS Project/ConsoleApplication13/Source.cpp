#include <iostream>
#include <conio.h>                    //for getch
#include <fstream>
#include <string>
#include <queue>
#include <map>
#include "AdminClass.h"
using namespace std;
ofstream ofs;
fstream client;
fstream all;
struct All{
	string  brand, model, collor, type;
	int price, amount;
	int Id;
}data[100];

struct Client {
	string User_name,password;
}Cli[100];
void login(struct Client Cli[],int&, int);
void Register(struct Client Cli[], int&);
void ShowAllData(struct All data[], int&,int);
void Add();
void Display_brand_data();
void Display_brand_sorted();
void Update();
void Sorted_by_price();
void search_by_items();
void search_by_color();
void Buy();
void Delete();
int main(){
	AdminClass A;
	A.Admin_main_screen();
}
	/*int num_of_client = 0;
	int Num_Of_All = 0;
	int current_client_num=0, current_Type_Num=0;
	client.open("client.txt", ios::in);
	while (!client.eof())
	{
		client >> Cli[num_of_client].User_name >> Cli[num_of_client].password;
		if ((Cli[num_of_client].User_name != "") && (Cli[num_of_client].password!=""))
		num_of_client++;
	}
	client.close();
	//-------------------------------------------------------------------------------------------
	all.open("All.txt", ios ::in );
	while (!all.eof()){
		all >> data[Num_Of_All].type >> data[Num_Of_All].brand >> data[Num_Of_All].model >> data[Num_Of_All].collor >> data[Num_Of_All].price >> data[Num_Of_All].amount;
		if (data[Num_Of_All].brand != ""){
			Num_Of_All++;
		}
	}
	all.close();
	//system("cls");
	//ShowAllData(data, current_Type_Num, Num_Of_All);// h3ml delet l de 
	int choise;
//	cout << "enter you chois " << endl << "1) login" << endl << "2) Register " << endl;
	cin >> choise;
	system("cls");
/*	if (choise == 1)
	{
		login(Cli, current_client_num, num_of_client);
	}
	else if (choise == 2) {
		 Register (Cli, num_of_client);
	}
	else {
		return 0;
	}
	if (choise == 1)
	{
		Buy();
		cout << "++++++++++++++++++++";
		return 0;
	}
	else if (choise == 2) {
		Display_brand_data();
		main();
	}
	else if (choise==3) { 
		Display_brand_sorted();
		main();
	}
	else if (choise == 4) {
		Update();
		main();
	}
	else if (choise == 5) {
		Sorted_by_price();
		main();
	}
	else { return 0; }
}
void login(struct Client Cli[], int& current_client_num, int numOfClient){
	Client logclient ;
	cout << "user name is : " << endl;
	cin >> logclient.User_name;
	cout << "password is :  " << endl;
	cin >> logclient.password;
	system("cls");
	 current_client_num = 0;
	bool x = false;
	while (current_client_num < numOfClient){
		if ((logclient.User_name == Cli[0].User_name) && (logclient.password == Cli[0].password)) {
			cout << "he is admin " << endl;
			x = true;
			break;
		}
		else if ((logclient.User_name == Cli[current_client_num].User_name) && (logclient.password == Cli[current_client_num].password)){
			cout << "he is client "<<endl;
			x = true;
			break;
		}
		current_client_num++;
	}
		if (x == false){
			cout << "wrong information ";
		}
		 	
}
void Register(struct Client Cli[], int& num_of_client){
	Client newclient;
	cout << "user name is : " << endl; cin >> newclient.User_name;
	cout << "password is :  " << endl; cin >> newclient.password;
	int i = 0; bool x = false;
	while (i < num_of_client){
		if (newclient.User_name == Cli[i].User_name){
			x = true; break;                        }
		i++;
	}
	if (x==false){
		client.open("client.txt", ios::out | ios::app);
		client << endl << newclient.User_name << endl << newclient.password  ;
		client.close();
		num_of_client++;
	}
	else {
		system("cls");
		cout << "the user name is used" << endl << "choise 1 if you want to continue " << endl << "2 for retry ";
		int choise;
		cin >> choise;
		if (choise == 2){
			Register(Cli, num_of_client);
			main();
		}
		else {
			main();
		}}}

void ShowAllData(struct All data[], int& current_Type_Num, int Num_Of_All){

	current_Type_Num = 0;
	while (current_Type_Num < Num_Of_All){
		cout << data[current_Type_Num].type << "\t" << data[current_Type_Num].brand << "\t" << data[current_Type_Num].model << "\t" << data[current_Type_Num].collor << "\t" << data[current_Type_Num].price << "\n";
		current_Type_Num++;
	}
}
void Add(){
	string type;
	cout << "what you want to add mobil , laptop or TV ";
	cin >> type;
	All newdata;
	//type = All    3shan hw dh al file aly 3ndi
	system("cls");
	cout << "the brand is : ";   cin >> newdata.brand;
	cout << "the item is :";  cin >> newdata.model;
	cout << "the color is :"; cin >> newdata.collor;
	cout << "the price is :"; cin >> newdata.price;
	cout << "the amount is :";cin >> newdata.amount;
	all.open(type + ".txt", ios::out | ios::app);
	all << endl << "\t" << newdata.brand << "\t" << "\t" << newdata.model << "\t" << "\t" << newdata.collor << "\t" << "\t" << newdata.price << "\t" << "\t" << newdata.amount ;
	all.close();
	system("cls");
	cout << "added";
}
void Display_brand_data(){
	string Brand;
	All newdata;
	cout << "the brand is : ";
	cin >> Brand;
	system("cls");
	all.open("All.txt", ios::in);
	while (!all.eof())
	{
		all >> newdata.Id >> newdata.brand >> newdata.model >> newdata.collor >> newdata.price >> newdata.amount;
		if (newdata.brand == Brand){
			cout << newdata.Id << "\t" << newdata.model << "\t" << newdata.collor << "\t" << newdata.price << "\t" << newdata.amount;
		}
	}
	all.close();
	system("pause");
}
void Display_brand_sorted(){
	string type, Brand;
	cout << "what you want to show mobil , laptop or TV : "; cin >> type;
	cout << "the brand is : "; cin >> Brand;
	system("cls");
	map <int, int > q;
	all.open(type + ".txt", ios::in);
	int Num_Of_All = 0;
	All Newdata[100];
	while (!all.eof()){
		all >> Newdata[Num_Of_All].type >> Newdata[Num_Of_All].brand >> Newdata[Num_Of_All].model >> Newdata[Num_Of_All].collor >> Newdata[Num_Of_All].price >> Newdata[Num_Of_All].amount;
		if (Newdata[Num_Of_All].brand != ""){
			q[Newdata[Num_Of_All].price] =Num_Of_All;// el type hna hykon ID
			Num_Of_All++;
		}
	}
	all.close();
	map <int, int > ::iterator it;
	for (it = q.begin(); it != q.end(); it++)
	{
		if (Newdata[it->second].brand == Brand){
			//cout << it->first << " " << it->second << endl;
			cout << Newdata[it->second].type << "\t" << "\t" << Newdata[it->second].brand << "\t" << "\t" << Newdata[it->second].model << "\t" << "\t" << Newdata[it->second].price << "\t" << "\t" << Newdata[it->second].collor << endl;
		}
	}
}
void Update(){
	fstream temp,all;
	string type, Brand, ITEM; int NewPrice;
	cout << "what you want to Update mobil , laptop or TV : "; cin >> type;
	cout << "the brand is : " ; cin >> Brand ;
	cout << "the item is :" ; cin >> ITEM ;
	cout << "the New price is : " ; cin >> NewPrice ;
	system("cls");
	temp.open("temp.txt", ios::out | ios::app);
	All newdata; 
	all.open(type + ".txt", ios:: in);
	while (!all.eof()){
		all >> newdata.type >> newdata.brand >> newdata.model >> newdata.collor >> newdata.price >> newdata.amount;
		if (newdata.type != ""){
		if ((newdata.brand == Brand) && (newdata.model == ITEM)){
			newdata.price = NewPrice;
			temp << endl << newdata.type << "\t" << newdata.brand << "\t" << "\t" << newdata.model << "\t" << "\t" << newdata.collor << "\t" << "\t" << newdata.price << "\t" << "\t" << newdata.amount;
		}
		else {
			temp << endl << newdata.type << "\t" << newdata.brand << "\t" << "\t" << newdata.model << "\t" << "\t" << newdata.collor << "\t" << "\t" << newdata.price << "\t" << "\t" << newdata.amount;
		}
	}
}
	temp.close();
	all.close();
	ofs.open(type + ".txt", ofstream::out | ofstream::trunc);
	ofs.close();
	temp.open("temp.txt", ios::in);
	all.open(type + ".txt", ios::out | ios::app);
	while (!temp.eof())
	{
		temp >> newdata.type >> newdata.brand >> newdata.model >> newdata.collor >> newdata.price >> newdata.amount;
		all << endl << newdata.type << "\t" << newdata.brand << "\t" << "\t" << newdata.model << "\t" << "\t" << newdata.collor << "\t" << "\t" << newdata.price << "\t" << "\t" << newdata.amount;
	}
	temp.close();
	all.close();
	ofs.open("temp.txt", ofstream::out | ofstream::trunc);
	ofs.close();
	remove("temp.txt");
	cout << "done";
}
void Sorted_by_price(){
	string type, Brand;
	int price;
	cout << "what you want to show mobil , laptop or TV : "; cin >> type;
	cout << "the brand is : "; cin >> Brand;
	cout << "the price is : "; cin >> price;
	system("cls");
	map <int, int > q;
	all.open(type + ".txt", ios::in);
	int Num_Of_All = 0;
	All Newdata[100];
	while (!all.eof()){
		all >> Newdata[Num_Of_All].type >> Newdata[Num_Of_All].brand >> Newdata[Num_Of_All].model >> Newdata[Num_Of_All].collor >> Newdata[Num_Of_All].price >> Newdata[Num_Of_All].amount;
		if ((Newdata[Num_Of_All].brand==Brand)&&(Newdata[Num_Of_All].price<=price)){
			q[Newdata[Num_Of_All].price] = Num_Of_All;
			Num_Of_All++;
		}
	}
	all.close();
	map <int, int > ::iterator it;
	for (it = q.begin(); it != q.end(); it++)
	{
			//cout << it->first << " " << it->second << endl;
			cout << Newdata[it->second].type << "\t" << "\t" << Newdata[it->second].brand << "\t" << "\t" << Newdata[it->second].model << "\t" << "\t" << Newdata[it->second].price << "\t" << "\t" << Newdata[it->second].collor << endl;
		}
}
void search_by_color(){
	string type, Brand,color;
	cout << "what you want to show mobil , laptop or TV : "; cin >> type;
	cout << "the brand is : "; cin >> Brand;
	cout << "the color is : "; cin >> color;
	system("cls");
	all.open(type + ".txt", ios::in);
//	int Num_Of_All = 0;
	All Newdata;
	while (!all.eof()){
		all >> Newdata.type >> Newdata.brand >> Newdata.model >> Newdata.collor >> Newdata.price >> Newdata.amount;
		if ((Newdata.brand == Brand) && (Newdata.collor == color)){
			cout << Newdata.type << "\t" << Newdata.brand << "\t" << Newdata.model << "\t" << Newdata.collor << "\t" << Newdata.price << endl;
		}
	}
}
void search_by_items(){
	string type, Brand, Item;
	cout << "what you want to show mobil , laptop or TV : "; cin >> type;
	cout << "the brand is : "; cin >> Brand;
	cout << "the color is : "; cin >> Item;
	system("cls");
	all.open(type + ".txt", ios::in);
	//	int Num_Of_All = 0;
	All Newdata;
	while (!all.eof()){
		all >> Newdata.type >> Newdata.brand >> Newdata.model >> Newdata.collor >> Newdata.price >> Newdata.amount;
		if ((Newdata.brand == Brand) && (Newdata.model == Item)){
			cout << Newdata.type << "\t" << Newdata.brand << "\t" << Newdata.model << "\t" << Newdata.collor << "\t" << Newdata.price << endl;
		}
	}

}
void Delete(){
	fstream temp, all;
	string type, Brand, ITEM;
	cout << "what you want to Update mobil , laptop or TV : "; cin >> type;
	cout << "the brand is : "; cin >> Brand;
	cout << "the item is :"; cin >> ITEM;
	system("cls");
	All newdata;
	temp.open("temp.txt", ios::out | ios::app);
	all.open(type + ".txt", ios::in);
	while (!all.eof()){
		all >> newdata.type >> newdata.brand >> newdata.model >> newdata.collor >> newdata.price >> newdata.amount;
		if (newdata.type != ""){
			if ((newdata.brand != Brand) && (newdata.model != ITEM)){
				temp << endl << newdata.type << "\t" << newdata.brand << "\t" << "\t" << newdata.model << "\t" << "\t" << newdata.collor << "\t" << "\t" << newdata.price << "\t" << "\t" << newdata.amount;
			}
			/*else {
				temp << endl << newdata.type << "\t" << newdata.brand << "\t" << "\t" << newdata.model << "\t" << "\t" << newdata.collor << "\t" << "\t" << newdata.price << "\t" << "\t" << newdata.amount;
			}
		}
	}
	temp.close();
	all.close();
	ofs.open(type + ".txt", ofstream::out | ofstream::trunc);
	ofs.close();
	temp.open("temp.txt", ios::in);
	all.open(type + ".txt", ios::out | ios::app);
	while (!temp.eof())
	{
		temp >> newdata.type >> newdata.brand >> newdata.model >> newdata.collor >> newdata.price >> newdata.amount;
		all << endl << newdata.type << "\t" << newdata.brand << "\t" << "\t" << newdata.model << "\t" << "\t" << newdata.collor << "\t" << "\t" << newdata.price << "\t" << "\t" << newdata.amount;
	}
	temp.close();
	all.close();
	remove("temp.txt");
	cout << "done";
}
void Buy(){
	ofstream ofs;
	int Num_Of_All = 0,id;
	cout << "the id you want is : "; cin >> id;
	All Newdata[100];
	bool x = false;
	map <int, int > q;
	all.open("All.txt", ios::in);
	while (!all.eof()){
		all >> Newdata[Num_Of_All].Id >> Newdata[Num_Of_All].brand >> Newdata[Num_Of_All].model >> Newdata[Num_Of_All].collor >> Newdata[Num_Of_All].price >> Newdata[Num_Of_All].amount;
		if (Newdata[Num_Of_All].brand != ""){
			q[Newdata[Num_Of_All].Id] = Num_Of_All;
			Num_Of_All++;
		}
	}
	all.close();
	map <int, int > ::iterator it;
	for (it = q.begin(); it != q.end(); it++){
		if ((it->first == id) && (Newdata[it->second].amount!=0)){
			Newdata[it->second].amount--;
			x = true;
			cout << "done ";
			break;

		}
	}
	if (x == false){
		int n;
		cout << "the id is wrong or ran out \n enter 1 to try again or 2 to exit "; cin >> n;
		if (n == 1){
			Buy();
			return;
		}
		else if (n==2) {
			return;
		}
	}
	ofs.open("All.txt", ofstream::out | ofstream::trunc);
	ofs.close();
	all.open("All.txt", ios::out | ios::app);
	int i = 0;
	while (i<Num_Of_All)
	{	
		all << Newdata[i].Id << "\t" << Newdata[i].brand << "\t" << "\t" << Newdata[i].model << "\t" << "\t" << Newdata[i].collor << "\t" << "\t" << Newdata[i].price << "\t" << "\t" << Newdata[i].amount<<endl;
		i++;
	}
	cout << "---------------------------------------------";}
*/