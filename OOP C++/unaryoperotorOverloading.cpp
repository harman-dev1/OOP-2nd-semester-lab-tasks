#include<iostream>
using namespace std;
class complex
{
    public:
    int a;
    complex operator-()
    {
        complex temp;
        temp.a = -a;
        return temp;
    }
};
main()
{
    complex c1,c2,c3;
    c1.a = 5;
    c2 = c1.operator-();
    cout << c2.a;
}