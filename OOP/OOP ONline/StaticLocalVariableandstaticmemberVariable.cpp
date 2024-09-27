#include<iostream>
using namespace std;
void fun()
{
    int y = 10;
    static int y;
    cout << "y = " << y << endl;
    cout << "y = " << y;
}
main()
{
    fun();
}