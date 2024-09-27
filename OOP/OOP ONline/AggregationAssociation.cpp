#include<iostream>
#include<conio.h>
#include<string.h>
using namespace std;
class Address
{
    int hno;
    char colony[20];
    char city[20];
    public:
    Address(int x,char *p,char *q)
    {
        hno = x;
        strcpy(colony,p);
        strcpy(city,q);
    }
    void Show()
    {
       cout << hno << endl;
       cout << colony<<endl;
       cout << city << endl;
    }
};
class person
{
    char name[20];
    Address *p;
    public:
    void setAddress(Address *ptr)
    {
        p = ptr; 
    }
};
main()
{
    Address add1(61,"fazabur","Lahore");
    person rahul,ravi;
    rahul.setAddress(&add1);
    ravi.setAddress(&add1);
    add1.Show();
}