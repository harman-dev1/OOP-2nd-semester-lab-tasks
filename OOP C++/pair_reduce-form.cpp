#include<iostream>
using namespace std;
main()
{
    int arr[] = {10,16,7,14,5,3,2,9};
    int redNumber = 0;
    for(int i = 0; i < 8; i++)
    {
        if(redNumber < arr[i])
        {
            redNumber = arr[i];
            arr[i] = i;            
        }
    }
    for(int i = 0; i < 8;i++)
    {
        cout << arr[i] << " ";
    }
}