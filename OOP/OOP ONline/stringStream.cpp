#include<iostream>
#include <sstream>
using namespace std;
main()
{
    stringstream sso,sso2;
    string whole = "fuck";
    int num1 = 7;
    sso << num1;
    string num3,num4;
    sso >> num3;
    int num2 = 8;
    sso2 << num2;
    sso2 >> num4;
    whole = whole + "," + num3 + num4;
    cout << whole;
}