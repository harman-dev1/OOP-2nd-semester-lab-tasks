#include<iostream>
using namespace std;
class anime
{
    public:
    int id;
    ~anime()
    {
        cout << "Destructor of anime object" << id << "\n";
    }
};
main()
{
    anime a;
    a.id = 27;
    anime a3;
    a3.id = 30;
    for(int i = 0; i < 4 ;i++)
    {
        anime a1;
        a1.id = i;
    }
    
}