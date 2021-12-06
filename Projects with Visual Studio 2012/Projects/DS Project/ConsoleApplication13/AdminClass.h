#include <iostream>
#include <conio.h>                    //for getch
#include <fstream>
#include <string>
#include <queue>
#include <map>
using namespace std;
#pragma once
class AdminClass
{
public:
	string Brand, ITEM;
	fstream all, temp;
	ofstream ofs;
	struct All{
		string  brand, model, collor;
		int price, amount;
		int Id;
	}data[100];
	int Num_Of_All = 0;
	AdminClass();
	void Admin_main_screen();
	void ShowAllData();
	void Add();
	void Display_brand_data();
	void Display_brand_sorted();
	void Update();
	void Sorted_by_price();
	void search_by_items();
	void search_by_color();
	void Delete();
	~AdminClass();
};

