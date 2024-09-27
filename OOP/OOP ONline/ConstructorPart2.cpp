#include<iostream>
using namespace std;
class complex
{
    private:
    int a, b;
    public:
    complex()
    {
        a = 0;b = 0; 
    }
    complex(int x)
    {
        a = 10,b = 20;
    }
    void show_data()
    {
        cout<<"a = "<<a<<"\t b = "<<b;
    }
};
main()
{
    system("cls");
    complex c1,c2 = 8; //oR c2 can be written as c2(8) ,,,, c2 can be as c2 = complex(5)  
    c1.show_data();
    c2.show_data();
}