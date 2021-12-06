#include <iostream>
#include <conio.h>                    //for getch
#include <fstream>
#include <string>
#include <queue>
#include <map>
using namespace std;
#pragma once
class clientclass
{
public:
	struct All{
		string  brand, model, collor, type;
		int price, amount;
		int Id;
	}data[100];
	clientclass();
	void client_main_screen();
	void Buy();
	void Sorted_by_price();
	void search_by_items();
	void search_by_color();
	void Display_brand_data();
	void Display_brand_sorted();
	void ShowAllData(struct All data[], int&, int);
	~clientclass();
};

