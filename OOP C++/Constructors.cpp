#include<iostream>
using namespace std;
class Anime
{
    public :
    int chapters;
    //Default Constructor
    public :
    Anime()
    {
        chapters = 0;
        cout << "Default Anime Construtor :"<< chapters << "\n";
    }
    Anime(int aChapters)
    {
        chapters = aChapters;
        cout << "Parameterized Constructor :" <<chapters << "\n";
    }
};
main()
{
    Anime a1;
    Anime a2(29);
    Anime a3 = a2;
    cout << a3.chapters;
}
