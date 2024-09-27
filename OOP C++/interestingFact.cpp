#include<iostream>
using namespace std;
class Family
{
    public:
    int members;
    Family()
    {
        cout << "Default Zero Members \n";
    }
    Family(int members):members(members)
    {
        cout << members << "Members";
    }
}object,object1(7);
main()
{

}