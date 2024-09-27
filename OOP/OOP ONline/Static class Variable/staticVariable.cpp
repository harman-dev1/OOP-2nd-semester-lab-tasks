#include <iostream>
using namespace std;
class Employee
{
    public:
    int id;
    static int count;
    public :
    void setData()
    {
        cout << "Enter Id :";
        cin >> id;
        count ++ ;

    }
    void getData()
    {
        cout << "Id is "<<id << " Count is " <<count << endl;
    }
    static void getCount()
    {
        cout<< "Count :" << count << endl;
    }
};
int Employee:: count;
main()
{
    Employee b1,b2,b3;
    b1.setData();
    b1.getData(); 
    Employee::getCount();
    //b1.count;//we can access static variable with the help of object also
    //cout << endl << Employee::count;

    b2.setData();
    b2.getData();
    
    b3.setData();
    b3.getData();
}