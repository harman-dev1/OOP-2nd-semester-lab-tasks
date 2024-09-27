#include<iostream>
using namespace std;
class complex
{
    private:
    int a , b;
    public:
    void set_data(int x,int y)
    {
        a  = x,b = y; 
    }
    void show_data()
    {
        cout<<"a = "<<a<<"\t b = "<< b;
    }
    complex add(complex c)
    {
     
        c.a = a + c.a;
        c.b = b + c.b;
        return(c); 
    }
};
main()
{
    complex c1,c2,c3;
    c1.set_data(3,4);
    c2 = c1;
    c3 = c1.add(c2);
    c3.show_data();
    c1.show_data();
}