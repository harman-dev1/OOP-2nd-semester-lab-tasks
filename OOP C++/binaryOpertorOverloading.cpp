#include<iostream>
#include<conio.h>
using namespace std;
class complex
{
    public :
    int a, b;
    public:
    complex operator+(complex c)
    {
        complex temp1;
        temp1.a = c.a + a;
        return temp1;
    }
};
main()
{
    complex c1,c2,c3;
    c1.a = 5;
    c2.a = 5;
    
    c3 = c1+(c2);
    cout << c3.a;
}