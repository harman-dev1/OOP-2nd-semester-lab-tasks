#include<iostream>
using namespace std;
class complex
{
    private:
    int a , b;
    public:
    complex set_data(int,int);
    complex show_data()
    {
        cout<<"a = "<<a<<"\t"<<"b = "<<b;
    }
};
complex complex:: set_data(int x,int y)
{
    a = x,b = y;
}
main()
{
    complex c1;
    c1.set_data(10,20);
    c1.show_data();
}