#include "AdminClass.h"

AdminClass::AdminClass()
{
	Num_Of_All = 0;
}
void AdminClass::Admin_main_screen(){
	int choise;
	cout << "\n\n\n\n";
	cout << "*******************************************************************************************************\n";
	cout << "*******************************************************************************************************\n";
	cout << "\t\t*** 1) Show All Brands      ***\n";
	cout << "\t\t*** 2) Display Brand Data   ***\n";
	cout << "\t\t*** 3) Display Brand sorted ***\n";
	cout << "\t\t*** 4) Search By Color      ***\n";
	cout << "\t\t*** 5) Search By Item       ***\n";
	cout << "\t\t*** 6) Search By color      ***\n";
	cout << "\t\t*** 7) ADD                  ***\n";
	cout << "\t\t*** 8) Update               ***\n";
	cout << "\t\t*** 9) Delete               ***\n";
	cout << "\t\t*** 10) Exit                ***\n";
	cout << "*******************************************************************************************************\n";
	cout << "*******************************************************************************************************\n";
	cout << "your choise is : ";
	cin >> choise;
	system("cls");
	if (choise==1)
	{
		system("cls");
		ShowAllData();
	}
	else if (choise==2)
	{
		system("cls");
		Display_brand_data();
	}
	else if(choise==3)
	{
		system("cls");
		Display_brand_sorted();
	}
	else if(choise==4)
	{
		system("cls");
		Sorted_by_price();
	}
	else if(choise==5)
	{
		system("cls");
		search_by_color();
	}
	else if(choise==6)
	{
		system("cls");
		search_by_items();
	}
	else if (choise == 7)
	{
		system("cls");
		Add();
	}
	else if(choise==8)
	{
		system("cls");
		Update();
	}
	else if(choise==9)
	{
		system("cls");
		Delete();
	}
	else {
		return;
	}
}
void AdminClass:: Display_brand_data(){
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
	Admin_main_screen();
}
void AdminClass::ShowAllData(){
	system("cls");
	All newdata;
	all.open("All.txt", ios::in);
	while (!all.eof())
	{
		all >> newdata.Id >> newdata.brand >> newdata.model >> newdata.collor >> newdata.price >> newdata.amount;
		cout << newdata.Id << "\t" << newdata.model << "\t" << newdata.collor << "\t" << newdata.price << "\t" << newdata.amount;
	}
	system("pause");
	Admin_main_screen();
}
void AdminClass::Delete(){
		cout << "the brand is : "; cin >> Brand;
		cout << "the item is :"; cin >> ITEM;
		system("cls");
		All newdata;
		temp.open("temp.txt", ios::out | ios::app);
		all.open("All.txt", ios::in);
		while (!all.eof()){
			all >> newdata.Id>> newdata.brand >> newdata.model >> newdata.collor >> newdata.price >> newdata.amount;
			if (newdata.brand != ""){
				if ((newdata.brand != Brand) && (newdata.model != ITEM)){
					temp << endl << newdata.Id << "\t" << newdata.brand << "\t" << "\t" << newdata.model << "\t" << "\t" << newdata.collor << "\t" << "\t" << newdata.price << "\t" << "\t" << newdata.amount;
				}
			}
		}
		temp.close();
		all.close();
		ofs.open("All.txt", ofstream::out | ofstream::trunc);
		ofs.close();
		temp.open("temp.txt", ios::in);
		all.open("All.txt", ios::out | ios::app);
		while (!temp.eof())
		{
			temp >> newdata.Id >> newdata.brand >> newdata.model >> newdata.collor >> newdata.price >> newdata.amount;
			all << endl << newdata.Id << "\t" << newdata.brand << "\t" << "\t" << newdata.model << "\t" << "\t" << newdata.collor << "\t" << "\t" << newdata.price << "\t" << "\t" << newdata.amount;
		}
		temp.close();
		all.close();
		remove("temp.txt");
		cout << "done";
		system("pause");
		Admin_main_screen();
}
void AdminClass::Display_brand_sorted(){
	cout << "the brand is : "; cin >> Brand;
	system("cls");
	map <int, int > q;
	all.open("All.txt", ios::in);
	int Num_Of_All = 0;
	All Newdata[100];
	while (!all.eof()){
		all >> Newdata[Num_Of_All].Id >> Newdata[Num_Of_All].brand >> Newdata[Num_Of_All].model >> Newdata[Num_Of_All].collor >> Newdata[Num_Of_All].price >> Newdata[Num_Of_All].amount;
		if (Newdata[Num_Of_All].brand != ""){
			q[Newdata[Num_Of_All].price] = Num_Of_All;
			Num_Of_All++;
		}
	}
	all.close();
	map <int, int > ::iterator it;
	for (it = q.begin(); it != q.end(); it++)
	{
		if (Newdata[it->second].brand == Brand){
			cout << Newdata[it->second].Id << "\t" << "\t" << Newdata[it->second].brand << "\t" << "\t" << Newdata[it->second].model << "\t" << "\t" << Newdata[it->second].price << "\t" << "\t" << Newdata[it->second].collor << endl;
		}
	}
	system("pause");
	Admin_main_screen();
}
void AdminClass::Add(){
	All newdata, Newdata[100];
	map <int, int > q;
	Num_Of_All = 0;
	while (!all.eof()){
		all >> Newdata[Num_Of_All].Id >> Newdata[Num_Of_All].brand >> Newdata[Num_Of_All].model >> Newdata[Num_Of_All].collor >> Newdata[Num_Of_All].price >> Newdata[Num_Of_All].amount;
		if (Newdata[Num_Of_All].brand != ""){
			q[Newdata[Num_Of_All].Id] = Num_Of_All;
			Num_Of_All++;
		}
	}
	int tryloop = 0;
	while (tryloop<3)
	{	cout << "the id is : "; cin >> newdata.Id;
		if (q[newdata.Id] == NULL){
			cout << "the brand is : ";   cin >> newdata.brand;
			cout << "the item is :";  cin >> newdata.model;
			cout << "the color is :"; cin >> newdata.collor;
			cout << "the price is :"; cin >> newdata.price;
			cout << "the amount is :"; cin >> newdata.amount;
			all.open("All.txt", ios::out | ios::app);
			all << endl << "\t" << newdata.brand << "\t" << "\t" << newdata.model << "\t" << "\t" << newdata.collor << "\t" << "\t" << newdata.price << "\t" << "\t" << newdata.amount;
			all.close();
			system("cls");
			cout << "added";
			system("pause");
			Admin_main_screen();
			break;
		}
		else {
			cout << "the id is relly used";
			tryloop++;
		}
		if (tryloop==3)
		{
			cout << "try again later ";
			system("pause");
			Admin_main_screen();
			break;
		}
	}
}
void AdminClass::Update(){
	int NewPrice;
	cout << "the brand is : "; cin >> Brand;
	cout << "the item is :"; cin >> ITEM;
	cout << "the New price is : "; cin >> NewPrice;
	system("cls");
	temp.open("temp.txt", ios::out | ios::app);
	All newdata;
	all.open("All.txt", ios::in);
	while (!all.eof()){
		all >> newdata.Id >> newdata.brand >> newdata.model >> newdata.collor >> newdata.price >> newdata.amount;
		if (newdata.brand != ""){
			if ((newdata.brand == Brand) && (newdata.model == ITEM)){
				newdata.price = NewPrice;
				temp << endl << newdata.Id << "\t" << newdata.brand << "\t" << "\t" << newdata.model << "\t" << "\t" << newdata.collor << "\t" << "\t" << newdata.price << "\t" << "\t" << newdata.amount;
			}
			else {
				temp << endl << newdata.Id << "\t" << newdata.brand << "\t" << "\t" << newdata.model << "\t" << "\t" << newdata.collor << "\t" << "\t" << newdata.price << "\t" << "\t" << newdata.amount;
			}
		}
	}
	temp.close();
	all.close();
	ofs.open("All.txt", ofstream::out | ofstream::trunc);
	ofs.close();
	temp.open("temp.txt", ios::in);
	all.open("All.txt", ios::out | ios::app);
	while (!temp.eof())
	{
		temp >> newdata.Id >> newdata.brand >> newdata.model >> newdata.collor >> newdata.price >> newdata.amount;
		all << endl << newdata.Id << "\t" << newdata.brand << "\t" << "\t" << newdata.model << "\t" << "\t" << newdata.collor << "\t" << "\t" << newdata.price << "\t" << "\t" << newdata.amount;
	}
	temp.close();
	all.close();
	ofs.open("temp.txt", ofstream::out | ofstream::trunc);
	ofs.close();
	remove("temp.txt");
	cout << "done";
	system("pause");
	Admin_main_screen();
}
void AdminClass::Sorted_by_price(){
	int price;
	cout << "the brand is : "; cin >> Brand;
	cout << "the price is : "; cin >> price;
	system("cls");
	map <int, int > q;
	all.open("All.txt", ios::in);
	int Num_Of_All = 0;
	All Newdata[100];
	while (!all.eof()){
		all >> Newdata[Num_Of_All].Id >> Newdata[Num_Of_All].brand >> Newdata[Num_Of_All].model >> Newdata[Num_Of_All].collor >> Newdata[Num_Of_All].price >> Newdata[Num_Of_All].amount;
		if ((Newdata[Num_Of_All].brand == Brand) && (Newdata[Num_Of_All].price <= price)){
			q[Newdata[Num_Of_All].price] = Num_Of_All;
			Num_Of_All++;
		}
	}
	all.close();
	map <int, int > ::iterator it;
	for (it = q.begin(); it != q.end(); it++)
	{
		cout << Newdata[it->second].Id << "\t" << "\t" << Newdata[it->second].brand << "\t" << "\t" << Newdata[it->second].model << "\t" << "\t" << Newdata[it->second].price << "\t" << "\t" << Newdata[it->second].collor << endl;
	}
	system("pause");
	Admin_main_screen();
}
void AdminClass::search_by_items(){
	string Item;
	cout << "the brand is : "; cin >> Brand;
	cout << "the color is : "; cin >> Item;
	system("cls");
	all.open("All.txt", ios::in);
	All Newdata;
	while (!all.eof()){
		all >> Newdata.Id >> Newdata.brand >> Newdata.model >> Newdata.collor >> Newdata.price >> Newdata.amount;
		if ((Newdata.brand == Brand) && (Newdata.model == Item)){
			cout << Newdata.Id << "\t" << Newdata.brand << "\t" << Newdata.model << "\t" << Newdata.collor << "\t" << Newdata.price << endl;
		}
	}
	system("pause");
	Admin_main_screen();
}
void AdminClass::search_by_color(){
	string Brand, color;
	cout << "the brand is : "; cin >> Brand;
	cout << "the color is : "; cin >> color;
	system("cls");
	all.open("All.txt", ios::in);
	All Newdata;
	while (!all.eof()){
		all >> Newdata.Id >> Newdata.brand >> Newdata.model >> Newdata.collor >> Newdata.price >> Newdata.amount;
		if ((Newdata.brand == Brand) && (Newdata.collor == color)){
			cout << Newdata.Id << "\t" << Newdata.brand << "\t" << Newdata.model << "\t" << Newdata.collor << "\t" << Newdata.price << endl;
		}
	}
	system("pause");
	Admin_main_screen();
}

AdminClass::~AdminClass()
{
}
