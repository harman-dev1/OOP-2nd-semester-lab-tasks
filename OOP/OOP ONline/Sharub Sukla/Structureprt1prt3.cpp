#include<iostream>
using namespace std;
struct book
{
    int bookId;
    char title[20];
    float price;
};
main()
{
    struct book b;
    cout<<"ENter Book ID :";
    cin>>b.bookId;
    cout<<"Enter Book Title :";
    cin>>b.title[20];
    cout<<"Enter Book Price :";
    cin>>b.price;
    cout<<b.bookId<<endl<<b.price<<endl<<b.title;    
}