#include<iostream>
using namespace std;
class complex 
{
   
    public:
    int a,b;
    complex(int x,int y)
    {
        a = x;b = y;
    }
    complex()
    {
        
    }
    complex(int k)
    {
        a=k;
    }
    complex(complex &c)
    {
        a=c.a;
        b=c.b;
    }
};
int main()
{
    complex c1(2,4),c2,c3(5);
    complex c4 = c1;
}

