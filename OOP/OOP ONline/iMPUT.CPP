#include <iostream>
#include <sstream>
using namespace std;

/*
Enter code for class Student here.
Read statement for specification.
*/
class Student
{
    private:
    string f_name,l_name;
    int standard,age;
    public:
    void set_age(int pAge)
    {
        age = pAge;
    }
    void set_standard(int pStandard)
    {
        standard = pStandard;
    }
    void set_first_name(string pFName)
    {
        f_name = pFName;
    }
    void set_last_name(string pLName)
    {
        l_name = pLName;
    }
    int get_age()
    {
        return age;
    }
    string get_last_name()
    {
        return l_name;
    }
    string get_first_name()
    {
        return f_name;
    }
    int get_standard()
    {
        return standard;
    }
    string to_string()
    {
        stringstream sso,ss2;
        sso << age;
        string strAge;
        sso >> strAge;
        ss2 << standard;
        string strStandard;
        ss2 >> strStandard;
        string whole;
        whole =strAge + "," + f_name+"," + l_name +","+ strStandard;
        return whole; 
    }
};

int main() {
    int age, standard;
    string first_name, last_name;
    
    cin >> age >> first_name >> last_name >> standard;
    
    Student st;
    st.set_age(age);
    st.set_standard(standard);
    st.set_first_name(first_name);
    st.set_last_name(last_name);
    
    cout << st.get_age() << "\n";
    cout << st.get_last_name() << ", " << st.get_first_name() << "\n";
    cout << st.get_standard() << "\n";
    cout << "\n";
    cout << st.to_string();
    
    return 0;
}