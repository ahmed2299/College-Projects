//Powered by El-Haabeeddaaaaaaa
#include<iostream>           
#include<string>               
#include<windows.h>					 //for sound and color
#include<fstream>					 //for Read and Write files
#include<conio.h>                    //for getch
#include<ctime>                      //for Time and Date   
#include <mmsystem.h>
#pragma comment(lib, "winmm.lib")    //for sound
using namespace std;

fstream ClientData;                  // for Client information
fstream Clienttrans;                 // for Client transaction
fstream DailyReport;                 // for Daily  Report
fstream Emps;                        // for Bank Employees

struct Transaction
{
	string  Amount, Date, Type1;
};
struct client {
	Transaction ClientTrans[5];
	long long ID;
	string name, email, password, BirthDay, gender, MobileNumber;
	int age;
	long long deposite;

}User[100];
struct Employee {
	string name, email, Sec_Num , gender, MobileNumber, password,ID;

}BankEmpsData[10];

int Num_of_E = 0;
int Num_of_c = 0;
void start();                                //Welcome screen
string today();                              //to get DATE from system
void MainScreen();                           //Main Screen
void loading();                              //to load data while user choose an order
string HiddenPassword(string &pass);         //for hidden password
void EmpData();                              //to load Employees Data from file
void getdata();                              //to get data from user
void WriteData();                            //to write the data in its file after editting
void WriteTransActs();                       //to write Transactions in its file
void ReadTransActs();                        //to Read Transactions from file
void LoadData();                             //to Load Clients Data from file
void WriteDailyRep();                        //To Write Daily Report
void VeiwReport();                           //to show Daily Report 
void IfClient();                             //User Functionalities
int EditData(int ClientNum);                 //To Edit Data
void IfEmp();                                //Bank Employee Functionalities
	
void main() {
	//start();
	LoadData();					             //load data from file
	ReadTransActs();                         //Read transaction from file
	EmpData();                               //Read Employees Data

	PlaySound(TEXT("Welcome.wav"), NULL, SND_FILENAME | SND_ASYNC);
	cout << endl << endl << endl << endl << endl << endl << endl;
	cout << "\t\t\t Welcome to ATM system" << endl;   //welcome screen will be here 
		Sleep(1000);
	while (true) {                           // loop to return to main screen
		int choose;					         
		MainScreen();			             //call function of main screen to choose from
		cin >> choose;
		system("cls");
		if (choose == 1) {
			IfClient();
		}
		else if (choose == 2) {
			getdata();                       //function to get data from user
		}
		else if (choose == 3) {
			IfEmp();
		}
		else if (choose == 4) {
			break;
		}
	}
//	Write Data in files
	WriteTransActs();
	WriteDailyRep();
	WriteData(); 
	}

void start()
{
	system("color A");
	int i = 0;
	cout << endl << endl << endl << endl;
	cout << "Welcome To";
	Sleep(100);                                  // to wait
	system("CLS");                               // to clear the console
	cout << endl << endl << endl << endl << endl << endl;
	cout << "         " << "Welcome To";
	Sleep(100);
	system("CLS");
	cout << endl << endl << endl << endl << endl << endl << endl << endl;
	cout << "                " << "Welcome To";
	Sleep(100);
	system("CLS");
	cout << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl;
	cout << "                       " << "Welcome To";
	Sleep(100);
	system("CLS");
	cout << endl << endl << endl << endl << endl << endl << endl << endl;
	cout << "                              " << "Welcome To";
	Sleep(100);
	system("CLS");
	cout << endl << endl << endl << endl << endl << endl;
	cout << "                                        " << "Welcome To";
	Sleep(100);
	system("CLS");
	cout << endl << endl << endl << endl;
	cout << "                                                 " << "Welcome To";
	Sleep(100);
	system("CLS");
	cout << endl << endl << endl;
	cout << "                                                           " << "Welcome To";
	Sleep(100);
	system("CLS");
	cout << endl << endl << endl;
	cout << "                                                                     " << "Welcome To";
	Sleep(100);
	system("CLS");
	// A's refers to the names of team members
	while (i < 3)
	{
		cout << endl << endl << endl;
		system("color A");
		cout << "\t ======================================================================================================" << endl;
		cout << "\t |====================================================================================================|" << endl;
		cout << "\t ||    @@@@@@@             ************  **********        *******        ****                ****   ||  " << endl;
		cout << "\t ||  @@@@@@@@@@@           ************  **********      ***********      ******            ******   ||  " << endl;
		cout << "\t || @@@@     @@@@               **       ***            ****     ****     *******          *******   ||  " << endl;
		cout << "\t || @@@       @@@               **       ***            ***       ***     **** ***        *** ****   ||  " << endl;
		cout << "\t || @@@       @@@               **       ***            ***       ***     ****  ***      ***  ****   ||  " << endl;
		cout << "\t || @@@@@@@@@@@@@   =====       **       **********     *************     ****   ***    ***   ****   ||  " << endl;
		cout << "\t || @@@@@@@@@@@@@   =====       **       **********     *************     ****    ***  ***    ****   ||  " << endl;
		cout << "\t || @@@       @@@               **       ***            ***       ***     ****      ***       ****   ||  " << endl;
		cout << "\t || @@@       @@@               **       ***            ***       ***     ****                ****   ||  " << endl;
		cout << "\t || @@@       @@@               **       ***            ***       ***     ****                ****   ||  " << endl;
		cout << "\t || @@@       @@@               **       ***********    ***       ***   ********            ******** ||  " << endl;
		cout << "\t || @@@       @@@               **       ***********    ***       ***   ********            ******** ||  " << endl;
		cout << "\t |====================================================================================================|" << endl;
		cout << "\t ======================================================================================================" << endl;
		Sleep(100);
		system("cls");
		cout << endl << endl << endl;
		system("color B");
		cout << "\t ======================================================================================================" << endl;
		cout << "\t |====================================================================================================| " << endl;
		cout << "\t ||    @@@@@@@             @@@@@@@@@@@@@                                  @@@@                @@@@   || " << endl;
		cout << "\t ||  @@@@@@@@@@@           @@@@@@@@@@@@@                                  @@@@@@            @@@@@@   || " << endl;
		cout << "\t || @@@@     @@@@               @@@                                       @@@@@@@          @@@@@@@   || " << endl;
		cout << "\t || @@@       @@@               @@@                                       @@@@ @@@        @@@ @@@@   || " << endl;
		cout << "\t || @@@       @@@               @@@                                       @@@@  @@@      @@@  @@@@   || " << endl;
		cout << "\t || @@@@@@@@@@@@@               @@@                                       @@@@   @@@    @@@   @@@@   || " << endl;
		cout << "\t || @@@@@@@@@@@@@               @@@                                       @@@@    @@@  @@@    @@@@   || " << endl;
		cout << "\t || @@@       @@@    @@@@@      @@@                @@@@@                  @@@@      @@@       @@@@   || " << endl;
		cout << "\t || @@@       @@@   @@@@@@@     @@@               @@@@@@@                 @@@@                @@@@   || " << endl;
		cout << "\t || @@@       @@@    @@@@@      @@@                @@@@@                  @@@@                @@@@   || " << endl;
		cout << "\t || @@@       @@@               @@@                                     @@@@@@@@            @@@@@@@@ || " << endl;
		cout << "\t || @@@       @@@              @@@@@                                    @@@@@@@@            @@@@@@@@ || " << endl;
		cout << "\t ||===================================================================================================| " << endl;
		cout << "\t ======================================================================================================" << endl;
		Sleep(200);
		system("cls");
		i++;
	}
}
string today()                              //function to get DATE from system
{
	struct tm newtime;
	time_t now = time(0);
	localtime_s(&newtime, &now);
	int day = newtime.tm_mday;//day mn el 1 l 31
	int Month = 1 + newtime.tm_mon;//newtime month mn 0 l7d 11 w bnzwd 1
	int year = newtime.tm_year + 1900;//newtime is years from 1900
	string DD = to_string(day);
	string MM = to_string(Month);
	string YY = to_string(year);
	string Date = DD + "/" + MM + "/" + YY;
	return Date;
}
//void MainScreen();
void loading();
void MainScreen() {
	system("cls");
	system("color A");    // A for grean
	cout << endl << endl << endl << endl << endl << endl;
	cout << "\t\t        *****************************" << endl;
	cout << "\t\t        *****************************" << endl;
	cout << "\t\t        ***                       ***" << endl;
	cout << "\t\t        ***	  1.Client	  ***" << endl;
	cout << "\t\t        ***	  2.New client    ***" << endl;
	cout << "\t\t        ***	  3.Bank Employee ***" << endl;
	cout << "\t\t        ***	  4.Close         ***" << endl;
	cout << "\t\t        ***                       ***" << endl;
	cout << "\t\t        *****************************" << endl;
	cout << "\t\t        *****************************" << endl;
	cout << "\t\t\t Choose : ";
}
void loading()                   //to show a word loading ... while user choose an order
{
	cout << endl << endl << endl << endl << endl << endl;
	cout << "			Loading ";
	Sleep(1000);
	cout << ".";
	Sleep(1000);
	cout << ".";
	Sleep(1000);
	cout << ".";
	Sleep(1000);
	system("CLS");
}
string HiddenPassword(string &pass) {
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
void EmpData() {                 //to load Employees Data from file
	Emps.open("Emps.txt");
	while (!Emps.eof()) {
		getline(Emps, BankEmpsData[Num_of_E].name);
		getline(Emps, BankEmpsData[Num_of_E].ID);
		getline(Emps, BankEmpsData[Num_of_E].email);
		getline(Emps, BankEmpsData[Num_of_E].Sec_Num);
		getline(Emps, BankEmpsData[Num_of_E].MobileNumber);
		getline(Emps, BankEmpsData[Num_of_E].gender);
		getline(Emps, BankEmpsData[Num_of_E].password);
		//Emps >> BankEmpsData[Num_of_E].EmpNum;
		Num_of_E++;
	}
	Emps.close();
}
void getdata() {                     //to get data from user                                   
	cout << "\n\n			Enter your information \n\n			" << endl;
	ClientData << Num_of_c << endl;
	cout << "Name        : ";
	cin.ignore(1000, '\n');
	getline(cin, User[Num_of_c].name);
	cout << "e-mail      : ";
	getline(cin, User[Num_of_c].email);
	cout << "password    : ";
	//string pass = "";
	HiddenPassword(User[Num_of_c].password); //function for hidden password
//	User[Num_of_c].password = pass;

	cout << endl;
	cout << "Gender      : ";
	getline(cin, User[Num_of_c].gender);

	cout << "BirthDay    : ";
	getline(cin, User[Num_of_c].BirthDay);

	cout << "Mob Number  : ";
	getline(cin, User[Num_of_c].MobileNumber);

	cout << "age         : ";
	cin >> User[Num_of_c].age;

	cout << endl << endl << "Enter amount of money do you want to deposite : ";
	cin >> User[Num_of_c].deposite;
	User[Num_of_c].ClientTrans[0].Type1 = "Deposite";
	string s = to_string(User[Num_of_c].deposite);
	User[Num_of_c].ClientTrans[0].Amount = s;
	User[Num_of_c].ClientTrans[0].Date = today();

	system("cls");
	cout << endl << endl << endl << endl << endl << endl << endl;
	cout << "\t\t\t ***************************" << endl;
	cout << "\t\t\t | Your ID is : " << 2017170001 + Num_of_c << " |" << endl;
	cout << "\t\t\t ***************************" << endl;
	Sleep(2500);
	Num_of_c++;
	system("cls");
	cout << endl << endl << endl << endl << endl << endl << endl;
	cout << "\t\tThank You for using 'A-Team' ATM system " << endl;
	Sleep(1500);
	system("cls");
}
void WriteData() {                        //to write the data in its file after editting                          
	ClientData.open("DataBase.txt", ios::end);
	ClientData << "No data till now :(";     // to delete all data
	ClientData.close();
	ClientData.open("DataBase.txt", ios::end);
	for (int i = 0; i < Num_of_c; i++) {
		ClientData << User[i].name << endl;
		ClientData << User[i].email << endl;
		ClientData << User[i].password << endl;
		ClientData << User[i].gender << endl;
		ClientData << User[i].BirthDay << endl;
		ClientData << User[i].MobileNumber << endl;
		ClientData << User[i].age << endl;
		ClientData << User[i].deposite << endl;
		ClientData << 2017170001 + i << endl;
		//		ClientData << "****************" << endl;

	}
	ClientData.close();
}
void WriteTransActs() {                  //to write Transactions in its file
	Clienttrans.open("Transaction.txt", ios::end);
	Clienttrans << "No data till now :(";//to delete all data from file 
	Clienttrans.close();

	Clienttrans.open("Transaction.txt", ios::end);
	for (int i = 0; i < Num_of_c; i++) { //write data and set 0's at empty places in file
		for (int j = 0; j < 5; j++) {
			Clienttrans << User[i].ClientTrans[j].Amount << "#"
				<< User[i].ClientTrans[j].Type1 << "#"
				<< User[i].ClientTrans[j].Date << endl;
		}

	}
	Clienttrans.close();
}
void ReadTransActs() {                   //to Read Transactions from file
	//Read Transaction from file 
	Clienttrans.open("Transaction.txt");
	for (int i = 0; i < Num_of_c; i++) {
		for (int j = 0; j < 5; j++) {
			string s;
			getline(Clienttrans, s);//ba5od satr satr
			string st[3];
			string delimiter = "#";
			int pos = 0;
			string token;
			int cnt = 0;
			while ((pos = s.find(delimiter)) != string::npos) {//mfesh shebak
				token = s.substr(0, pos);
				st[cnt] = token;
				s.erase(0, pos + delimiter.length());
				cnt++;
			}
			st[cnt] = s;//de 3shan ba5od 2a5er 7ga mtb2ya
			User[i].ClientTrans[j].Amount = st[0];
			User[i].ClientTrans[j].Type1 = st[1];
			User[i].ClientTrans[j].Date = st[2];
		}
	}

	Clienttrans.close();
}
void LoadData() {                 //to Load Clients Data from file
	//load data 
	ClientData.open("DataBase.txt");
	while (!ClientData.eof()) {
		getline(ClientData, User[Num_of_c].name);
		if (User[0].name == "") {

		}
		else
		{
			if (Num_of_c > 0)
				getline(ClientData, User[Num_of_c].name);
			getline(ClientData, User[Num_of_c].email);
			getline(ClientData, User[Num_of_c].password);
			getline(ClientData, User[Num_of_c].gender);
			getline(ClientData, User[Num_of_c].BirthDay);
			getline(ClientData, User[Num_of_c].MobileNumber);
			ClientData >> User[Num_of_c].age;
			ClientData >> User[Num_of_c].deposite;
			ClientData >> User[Num_of_c].ID;
			//	getline(ClientData, stars);


			if (User[Num_of_c].ID == 0) {
				break;
			}
			Num_of_c++;
		}
	}
	ClientData.close();
}
void VeiwReport() {               //to show Daily Report 
	string Line, AllRep;
	bool found = false;
	DailyReport.open("Report.txt");
	while (!DailyReport.eof()) {
		getline(DailyReport, Line);
		if (Line == "") {
			//	cout << "Ops !! there is No Transaction today\n ";
			break;
			AllRep = "";
		}
		else
			found = true;
		AllRep += Line;
		AllRep += '\n';
	}
	if (!found) {
		cout << "\a\a\a\a\a\a\a"; //for Beep sound
		cout << "Ops !! there is No Transaction today\n ";
	}
	else {
		DailyReport.close();
		cout << AllRep;
	}
}
void WriteDailyRep() {                    //To Write Daily Report
	DailyReport.open("Report.txt", ios::end);
	DailyReport << "No data till now :(";         //to delete all data from file 
	DailyReport.close();

	DailyReport.open("Report.txt", ios::end);
	for (int i = 0; i < Num_of_c; i++) {
		//	if (i == 3) { break; }  
		DailyReport << User[i].ID << "  today's Transaction" << endl;
		for (int j = 0; j < 5; j++) {
			if (User[i].ClientTrans[j].Date == today()) {
				DailyReport << j + 1 << " --> " << User[i].ClientTrans[j].Amount << " LE   "
					<< User[i].ClientTrans[j].Type1 << "d" << endl;
			}
		}
		DailyReport << "******************************\n";
	}
	DailyReport.close();
}
int EditData(int ClientNum) {
	int Edit;
	string New = "";
	cout << endl << endl << endl << endl << endl;
	cout << "\t\t Your current Data are those below :" << endl;
	cout << "\t\t -----------------------------------" << endl;
	cout << "\t\t 1 -) Name	       : " << User[ClientNum].name << endl << endl;
	cout << "\t\t 2 -) Email	       : " << User[ClientNum].email << endl << endl;
	cout << "\t\t 3 -) Mobile Number    : " << User[ClientNum].MobileNumber << endl << endl;
	cout << "\t\t 4 -) Password         : " << User[ClientNum].password << endl << endl;
	cout << "\t\t----------------------------------------------------\n";
	cout << "What do you want to edit on your data ? ";
	cin >> Edit;
	system("cls");
	cout << endl << endl << endl << endl << endl;
	switch (Edit) {
	case 1:
		cout << "Enter your New name to Replace with the old one \n";
		cin.ignore(1000, '\n');
		getline(cin, New);
		User[ClientNum].name = New;
		break;
	case 2:
		cout << "Enter Your New E-mail to Replace with the old one \n";
		cin.ignore(1000, '\n');
		getline(cin, New);
		User[ClientNum].email = New;
		break;
	case 3:
		cout << "Enter Your New Mobile Number to Replace with the old one \n";
		cin.ignore(1000, '\n');
		getline(cin, New);
		User[ClientNum].MobileNumber = New;
		break;
	case 4:
		cout << "Enter Your New Password to Replace with the old one \n";

		HiddenPassword(New);
		User[ClientNum].password = New;
		cout << endl;
		break;
	}
	return 0;
}

void IfClient() {                  //User Functionalities
	long long ID;
	int	ClientNum;
	bool found = false;
	string pass = "";
	cout << endl << endl << endl << endl << endl << endl;
	cout << "\t\t\t Enter your ID       : ";
	cin >> ID;
	cout << "\t\t\t Enter your password : ";
	HiddenPassword(pass);
	system("cls");
	ClientData.open("DataBase.txt");
	for (int i = 0; i < Num_of_c; i++) {
		if (User[i].ID == ID && User[i].password == pass) {
			found = true;
			ClientNum = i;
			cout << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl;
			cout << "\t\t\tyou have logged in succesfully" << endl;
			Sleep(2000);
			break;
		}
	}
	ClientData.close();
	if (!found) {
		cout << "\a\a\a\a\a\a"; //for Beep sound
		cout << "Error Data Entered !" << endl;
		Sleep(1500);
		system("cls");
		//	break;
	}

	if (found) {
		system("cls");
		while (true) {
			cout << endl << endl << endl << endl << endl << endl << endl;
			cout << "\t |************************************|  " << endl;
			cout << "\t || 1.Show data                      ||  " << endl;
			cout << "\t || 2.withdraw cash                  ||  " << endl;
			cout << "\t || 3.deposit cash                   ||  " << endl;
			cout << "\t || 4.Check your balance             ||  " << endl;
			cout << "\t || 5.your last 5 transactions       ||  " << endl;
			cout << "\t || 6.Edit your data                 ||  " << endl;
			cout << "\t || 7.close                          ||  " << endl;
			cout << "\t |************************************|  " << endl;
			string Convert;                    //convert integer into string
			int Num_trans = 0;
			char Back;
			long long Money;
			int order;
			cin >> order;
			system("cls");
			loading();
			if (order == 1) {                           // to show the data
				cout << endl << endl << endl << endl << endl;
				cout << "\t\t Name		    : " << User[ClientNum].name << endl << endl;
				cout << "\t\t Email		    : " << User[ClientNum].email << endl << endl;
				cout << "\t\t Gender        : " << User[ClientNum].gender << endl << endl;
				cout << "\t\t Birthday      : " << User[ClientNum].BirthDay << endl << endl;
				cout << "\t\t Mobile Number : " << User[ClientNum].MobileNumber << endl << endl;
				cout << "\t\t Age           : " << User[ClientNum].age << endl << endl;
				cout << "\t\t Your balance  : " << User[ClientNum].deposite << " LE" << endl << endl;
				cout << "\t\t ID            : " << User[ClientNum].ID << endl;
				cout << endl << endl << endl << endl;
				cout << "Do you want to back to the menu (y/n)?" << endl;
				cin >> Back;
				if (Back == 'y')
					system("cls");
				else
					break;
			}

			else if (order == 2) {                           // to withdraw 
				cout << endl << endl << endl << endl << endl;
				cout << "your current balance is :" << User[ClientNum].deposite << " LE" << endl;
				while (true) {
					cout << "How much money do you want to withdraw : ";
					cin >> Money;

					if (Money > User[ClientNum].deposite) {
						cout << "please enter amount of money less than or equal your current balance! " << endl;
						continue;
					}
					else {
						Num_trans = 0;
						for (int j = 0; j < 5; j++) { //to know how many transaction for specfic Client
							User[ClientNum].ClientTrans[j].Amount;
							if (User[ClientNum].ClientTrans[j].Amount != "0") {
								Num_trans++;
							}
						}
						break;
					}

				}
				Convert = to_string(Money); //3shan n7wl el money l string
				User[ClientNum].ClientTrans[Num_trans].Amount = Convert;
				User[ClientNum].ClientTrans[Num_trans].Type1 = "Withdraw";
				User[ClientNum].ClientTrans[Num_trans].Date = today();
				User[ClientNum].deposite -= Money;
				cout << "your new balance is :" << User[ClientNum].deposite << " LE" << endl;
				cout << endl << endl << endl << endl;
				cout << "Do you want to back to the menu (y/n)?" << endl;
				cin >> Back;
				if (Back == 'y')
					system("cls");
				else
					break;
			}

			else if (order == 3) {                // to deposite
				cout << endl << endl << endl << endl << endl;
				cout << "your current balance is :" << User[ClientNum].deposite << " LE" << endl;
				cout << "How much money do you want to deposit : ";
				cin >> Money;
				Num_trans = 0;
				for (int j = 0; j < 5; j++) {  //to know how many transaction for specfic Client
					User[ClientNum].ClientTrans[j].Amount;
					if (User[ClientNum].ClientTrans[j].Amount != "0") {//n5zn mn 3nd el 3ndo inital value b zero
						Num_trans++;
					}
				}
				User[ClientNum].deposite += Money;
				cout << "your new balance is :" << User[ClientNum].deposite << " LE" << endl;
				Convert = to_string(Money);
				User[ClientNum].ClientTrans[Num_trans].Amount = Convert;
				User[ClientNum].ClientTrans[Num_trans].Type1 = "Deposite";
				User[ClientNum].ClientTrans[Num_trans].Date = today();

				cout << endl << endl << endl << endl;
				cout << "Do you want to back to the menu (y/n)?" << endl;
				cin >> Back;
				if (Back == 'y')
					system("cls");
				else
					break;
			}

			else if (order == 4) {              // show balance
				cout << endl << endl << endl << endl << endl;
				cout << "Your balance is : " << User[ClientNum].deposite << " LE" << endl;
				cout << endl << endl << endl << endl;
				cout << "Do you want to back to the menu (y/n)?" << endl;
				cin >> Back;
				if (Back == 'y')
					system("cls");
				else
					break;
			}
			else if (order == 5) {              // show last 5 transactions
				cout << endl << endl << endl << endl << endl;
				for (int j = 4; j >= 0; j--) {
					if (User[ClientNum].ClientTrans[j].Amount == "0") {//lw l2a sefr y continue l7d mywsl llrakm 4 w ybd2 el cout 
						continue;
					}
					else
					{
						cout << User[ClientNum].ClientTrans[j].Type1 << " : "
							<< User[ClientNum].ClientTrans[j].Amount << "   "
							<< User[ClientNum].ClientTrans[j].Date << endl;
					}
					
				}
				cout << endl << endl << endl << endl;
				cout << "Do you want to back to the menu (y/n)?" << endl;
				cin >> Back;
				if (Back == 'y')
					system("cls");
				else
					break;
			}
			else if (order == 6) {
				EditData(ClientNum);//de 3shan lw 3shan 3ayz a3ml edit lwa7d
				cout << "Your New Data has been saved successfully :) \n";
				cout << endl << endl << endl << endl;
				cout << "Do you want to back to the menu (y/n)?" << endl;
				cin >> Back;
				if (Back == 'y')
					system("cls");
				else
					break;
			}
			else if (order == 7) {
				break;
			}
		}
	}
}
void IfEmp() {                 //Bank Employee Functionalities

	int  EmpNum;
	string pass = "", ID;
	bool found = false;
	cout << "Enter your ID       : ";
	cin >> ID;
	cout << "Enter your password : ";
	HiddenPassword(pass);
	system("cls");

	Emps.open("Emps.txt");
	for (int i = 0; i < Num_of_E; i++) {
		if (BankEmpsData[i].ID.find(ID) != -1 && BankEmpsData[i].password.find(pass) != -1) {//-1 m3naha zy npos y3ny fadya
			found = true;
			EmpNum = i;
			cout << endl << endl << endl << endl << endl << endl;
			cout << "\t\t you have logged in succesfully" << endl;
			Sleep(2000);
			break;
		}
	}
	Emps.close();

	if (!found) {
		cout << "\a\a\a\a\a\a"; //for Beep sound
		cout << "Error Data Entered !" << endl;
		Sleep(1500);
		system("cls");
		//	break;
	}

	if (found) {
		while (true) {
			cout << endl << endl << endl << endl << endl;
			cout << "\t	1.View Your data\n\n";
			cout << "\t	2.View today's Transaction \n\n";
			cout << "\t	3.View Transaction of a specific client \n\n";
			cout << "\t	4.show Data of a specific Client \n\n";
			cout << "\t	5.close\n";
			int order;
			cin >> order;
			char Back;
			system("cls");
			int ClientNum;
			if (order == 1) {                            // to show the data
				cout << BankEmpsData[EmpNum].name << endl;
				cout << BankEmpsData[EmpNum].ID << endl;
				cout << BankEmpsData[EmpNum].email << endl;
				cout << BankEmpsData[EmpNum].Sec_Num << endl;
				cout << BankEmpsData[EmpNum].MobileNumber << endl;
				cout << BankEmpsData[EmpNum].gender << endl;

				cout << endl << endl << endl << endl;
				cout << "Do you want to back to the menu (y/n)?" << endl;
				cin >> Back;
				if (Back == 'y')
					system("cls");
				else
					break;
			}
			else if (order == 2) {                            // to show daily report
				VeiwReport();
				cout << endl << endl << endl << endl;
				cout << "Do you want to back to the menu (y/n)?" << endl;
				cin >> Back;
				if (Back == 'y')
					system("cls");
				else
					break;
			}
			else if (order == 3) {
				cout << "Here is a list of all our Clients Choose one of them \n\n";
				for (int i = 0; i < Num_of_c; i++) { //to show Clients Names
					cout << i + 1 << " -) " << User[i].name << endl;//btmshy 3la wa7ed wa7ed 3shan t5tar mnhom
				}
				cout << "Enter Client Number : ";
				cin >> ClientNum;
				system("cls");
				ClientNum -= 1;   //cause array is zero index
				cout << endl << endl << endl;
				for (int i = 0; i < 5; i++) {
					if (User[ClientNum].ClientTrans[i].Amount != "0") {
						cout << "There are " << User[ClientNum].ClientTrans[i].Amount << " LE ";
						cout << "was " << User[ClientNum].ClientTrans[i].Type1 << "d";
						cout << " at " << User[ClientNum].ClientTrans[i].Date;
						cout << endl;
					}
					else
						break;
				}
				cout << endl << endl << endl << endl;
				cout << "Do you want to back to the menu (y/n)?" << endl;
				cin >> Back;
				if (Back == 'y')
					system("cls");
				else
					break;
			}
			else if (order == 4) {
				cout << endl << endl << endl;
				cout << "Here is a list of all our Clients Choose one of them \n\n";
				for (int i = 0; i < Num_of_c; i++) { //to show Clients Names
					cout << i + 1 << " -) " << User[i].name << endl;
				}
				cout << endl << endl << endl;
				cout << "Enter Client Number : ";
				cin >> ClientNum;
				system("cls");
				ClientNum -= 1;   //cause array is zero index

				cout << "Name				: " << User[ClientNum].name << endl;
				cout << "Email				: " << User[ClientNum].email << endl;
				cout << "Gender				: " << User[ClientNum].gender << endl;
				cout << "Birthday			: " << User[ClientNum].BirthDay << endl;
				cout << "Mobile Number		: " << User[ClientNum].MobileNumber << endl;
				cout << "Age				: " << User[ClientNum].age << endl;
				cout << "His balance		: " << User[ClientNum].deposite << " LE" << endl;
				cout << "ID					: " << User[ClientNum].ID << endl;
				cout << endl << endl << endl;
				cout << "Do you want to back to the menu (y/n)?" << endl;
				cin >> Back;
				if (Back == 'y')
					system("cls");
				else
					break;
			}

			else if (order == 5) {
				break;
			}
		}
	}
}