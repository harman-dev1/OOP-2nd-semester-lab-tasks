#include<iostream>
using namespace std;
class complex 
{
    private:
    int a,b;
    public:
    complex set_data(int x,int y)
    {
        a = x;b = y;
    }
    complex show_data()
    {
        cout<<"a = "<<a<<endl<<"b = "<<b;
    }
};
main()
{
    system("cls");
    complex c1;
    c1.set_data(5,9);
    c1.show_data();

}