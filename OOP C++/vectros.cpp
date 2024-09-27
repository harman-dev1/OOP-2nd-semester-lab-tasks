#include<vector>
#include<stdio.h>
#include<iostream>
#include<algorithm>
using namespace std;
main()
{
    vector<int> v;
    v.push_back(7);
    v.push_back(14);
    v.push_back(27);
    cout << "1st method to print v vector \n";
    for(int i = 0; i < v.size();i ++)
    {
        cout<<v[i] << " ";
    }
    cout << "\n";
    cout << "2nd method to print v vector \n";
    vector<int>::iterator it;
    for(it = v.begin(); it != v.end(); it++)
    {
        
        cout<<*it << " ";
    }
    cout << "\n";
    cout << "3rd method to print v vector \n";
    for(auto a:v)
    {
        cout << a << " ";
    }
    cout << "\n";
    //2nd vector.......
    vector <int> v2(3);
    for(int i = 0; i < 3; i++)
    {
        cin >> v2[i];
    }
    for(auto a:v2)
    {
        cout << a << " ";
    }
    cout << "\n";
    swap(v,v2);
    for(auto a:v2)
    {
        cout << a << " ";
    }
    cout << "\n";
   // v.pop_back();
    for(auto a:v)
    {
        cout << a << " ";
    }

    sort(v2.begin(),v2.end());
    cout << "-------  Sorting    -------- \n";
    for(auto a:v)
    {
        cout << a << " ";
    }
    
}