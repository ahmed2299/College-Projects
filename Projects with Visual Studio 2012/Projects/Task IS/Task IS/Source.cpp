#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
using namespace std;
/*A node for every element with all its components grouped to a struct*/
struct Node {
	int ES , EF , LS , LF ,TimeRequired ,NumOfDeps;
	string NodeName, DependentNode;

	bool Is_end ;
/*A vector to connect nodes to each other using each early finish and the step by step connection to compare between the largest
early finish in each node*/
    vector <int> nodeA_index , nodeB_index;

    vector <int> nodeA_Ls , nodeB_Ef;
};

int main() {

    int shortest_time;

	int NumOfNodes;
	cout << "The number of your tasks:  ";
	cin >> NumOfNodes;

	Node *ArrayOfNodes = new Node[NumOfNodes];

	for (int i = 0; i < NumOfNodes ; i++) {

		cout << "Node name is: ";
		cin >> ArrayOfNodes[i].NodeName;

		cout << "The required time to do this task is: ";
        cin >> ArrayOfNodes[i].TimeRequired;

		char q;
		cout << "Is there a dependent node (y/n)?: ";
        cin >> q;

		if ( q == 'y' || q =='Y') {

			cout << "Then How many of them?: ";
			cin >> ArrayOfNodes[i].NumOfDeps;

			for (int j = 0 ; j < ArrayOfNodes[i].NumOfDeps ; j++) {

                cout << "Dependent Node No. " << j + 1 << " is: ";
                cin >> ArrayOfNodes[i].DependentNode;

                int k=0; // used downward

                 /*bool value to check if the input node really exists or its a faulty input from the user*/
                bool dep_found = false;

                /*a loop to check whether the dependent taken from the user already exists or its a faulty input */
                for (k=0 ; k<i ; k++)  {
                        if (ArrayOfNodes[k].NodeName == ArrayOfNodes[i].DependentNode) {
                        dep_found = true;
                        break;
                    }
                }

                if (!dep_found) {
                    cout<<"you entered a task doesn`t exist ! please enter a task that esists: "<<endl;
                    j--;
                    continue;
                }

                    // nodes after and befor ////
                ArrayOfNodes[i].nodeB_index.push_back(k);

                ArrayOfNodes[k].nodeA_index.push_back(i);
            }
        }
		else {
			 ArrayOfNodes[i].NumOfDeps = 0;
		}
            cout<<endl<<"*******************************************************"<<endl;
	}

	for (int i = 0; i < NumOfNodes; i++) {
        if (ArrayOfNodes[i].nodeA_index.size() == 0)
            ArrayOfNodes[i].Is_end =true;
		else
			ArrayOfNodes[i].Is_end = false;
	}

    // forward path

	for (int i = 0; i < NumOfNodes; i++) {

		if (ArrayOfNodes[i].NumOfDeps == 0) {
			ArrayOfNodes[i].ES = 0 ;
		}

        else if (ArrayOfNodes[i].NumOfDeps > 0){

            for (int j = 0 ; j<ArrayOfNodes[i].NumOfDeps ; j++) {

                ArrayOfNodes[i].nodeB_Ef.push_back(ArrayOfNodes[ArrayOfNodes[i].nodeB_index[j]].EF);

            }

            if (ArrayOfNodes[i].nodeB_Ef.size() == 1)
                ArrayOfNodes[i].ES = ArrayOfNodes[i].nodeB_Ef[0];

            else if (ArrayOfNodes[i].nodeB_Ef.size() > 1) {

                int max_Ef = ArrayOfNodes[i].nodeB_Ef[0];

                for (int j=0 ; j<ArrayOfNodes[i].nodeB_Ef.size() ; j++) {

                    if (max_Ef < ArrayOfNodes[i].nodeB_Ef[j])
                        max_Ef = ArrayOfNodes[i].nodeB_Ef[j];
                }

                ArrayOfNodes[i].ES = max_Ef;
            }

        }

        ArrayOfNodes[i].EF = ArrayOfNodes[i].ES + ArrayOfNodes[i].TimeRequired;
	}

	// shortest time

	int max_Ef = ArrayOfNodes[0].EF;

	for (int i=1 ; i<NumOfNodes ; i++) {
        if (max_Ef < ArrayOfNodes[i].EF)
            max_Ef = ArrayOfNodes[i].EF;
	}

	shortest_time = max_Ef;

	// back path

	for (int i=NumOfNodes-1 ; i >=0 ; i--) {

        if (ArrayOfNodes[i].Is_end) {
            ArrayOfNodes[i].LF = shortest_time;
        }

        else {
            for (int j=0; j<ArrayOfNodes[i].nodeA_index.size() ; j++) {
                ArrayOfNodes[i].nodeA_Ls.push_back(ArrayOfNodes[ ArrayOfNodes[i].nodeA_index[j] ].LS);
            }

            if (ArrayOfNodes[i].nodeA_Ls.size() == 1) {
                ArrayOfNodes[i].LF = ArrayOfNodes[i].nodeA_Ls[0];
            }

            else if (ArrayOfNodes[i].nodeA_Ls.size() > 1) {

                int min_ls = ArrayOfNodes[i].nodeA_Ls[0];

                for (int j=1 ; j<ArrayOfNodes[i].nodeA_Ls.size() ; j++) {

                    if (min_ls > ArrayOfNodes[i].nodeA_Ls[j])
                        min_ls = ArrayOfNodes[i].nodeA_Ls[j];
                }
                ArrayOfNodes[i].LF = min_ls;
            }
        }

        ArrayOfNodes[i].LS = ArrayOfNodes[i].LF - ArrayOfNodes[i].TimeRequired;
	}

    for (int i=0 ; i<NumOfNodes ; i++) {

            cout<<ArrayOfNodes[i].NodeName<<endl;

        cout<<ArrayOfNodes[i].ES<<"   "<<ArrayOfNodes[i].EF<<endl;
        cout<<ArrayOfNodes[i].LS<<"   "<<ArrayOfNodes[i].LF<<endl<<"********************************"<<endl;
	}

	cout<<"SHORTEST TIME "<<"***--->  "<<shortest_time<<"  <----***"<<endl;

	int i=0, j=0, k=0, x=0, sum=0, counter=0, store=0;
	vector <int> vec1,vec2,vec3,vec4;

	for (int z=0 ; z < NumOfNodes ; z++) {
        if (ArrayOfNodes[z].NumOfDeps == 0)
            vec4.push_back(z);
        }

    // critical path

	while (true) {

        if(ArrayOfNodes[i].Is_end==false) {

            if (ArrayOfNodes[i].NumOfDeps > 0) {

                vec1.push_back(j);
                vec2.push_back(ArrayOfNodes[vec3.at(vec3.size()-1)].nodeA_index.size()-1);
                vec3.push_back(i);

                i = ArrayOfNodes[i].nodeA_index[0];
                j=0;
            }

            else if (ArrayOfNodes[i].NumOfDeps == 0) {

                vec1.push_back(k);
                vec2.push_back(vec4.size()-1);
                vec3.push_back(i);

                i = ArrayOfNodes[i].nodeA_index[0];
            }
        }

        else {

            vec1.push_back(j);
            vec2.push_back(ArrayOfNodes[vec3.at(vec3.size()-1)].nodeA_index.size()-1);
            vec3.push_back(i);

            sum=0;
            for (int z=0 ; z < vec3.size() ; z++) {
                sum += ArrayOfNodes[vec3[z]].TimeRequired;
            }

            if (sum==shortest_time) {
                    cout<<endl<<"&&&&&&&&&&&&&&&&&&&&"<<endl;
                for (int z=0 ; z < vec3.size() ; z++) {
                    cout<<ArrayOfNodes[vec3[z]].NodeName;
                    if (z<vec3.size()-1) {cout<<"-->";}
                }
                cout<<endl;
                break;
            }

            else {

                for (int z=0 ; z < vec3.size() ; ) {
                    if (vec1.at(vec1.size()-1)== vec2.at(vec2.size()-1)) {

                        vec1.pop_back(); vec2.pop_back(); vec3.pop_back();
                        continue;
                    }
                    else {
                        if (vec3.size()==1) {

                            int t ;
                            for ( t=0 ; t<vec4.size() ; t++){
                                if (vec3[0]==vec4[t]) {
                                    break;
                                }
                            }

                            k=t+1;
                            i=vec4.at(t+1);
                            vec1.pop_back();  vec2.pop_back();  vec3.pop_back();
                            break;
                        }
                        else {
                            vec2.pop_back();
                            vec3.pop_back();

                            store=vec1.at(vec1.size()-1);
                            vec1.pop_back();

                            j=store+1;
                            i=ArrayOfNodes[vec3.at(vec3.size()-1)].nodeA_index[j];

                            store=0;
                            break;
                        }
                    }
                }
            }
        }
	}
	return 0;
}