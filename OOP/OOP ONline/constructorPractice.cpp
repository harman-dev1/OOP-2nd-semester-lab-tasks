#include<iostream>
using namespace std;
class student
{
    public:
    string name;
    float matricMarks;
    float fscMarks;
    float aggregate;
};
main()
{
    student s1;
    cout << s1.name<<endl;
    cout << s1.matricMarks<<endl;
    cout << s1.fscMarks<<endl;
    cout<< s1.aggregate <<endl; 
}