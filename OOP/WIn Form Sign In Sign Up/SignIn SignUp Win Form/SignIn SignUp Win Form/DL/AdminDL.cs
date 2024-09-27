using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

using BMS.BL;

namespace BMS.DL
{
    //Admin List.....................................................


    class ListsDLUser
    {
        //Sign Up File Handling ...........................

        public static void signUp_File(string path, string aEmail, string aPassword, string aName, string aAddress, long aPhoneNo, long aCnic)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            StreamWriter file = new StreamWriter(path, true);
            
            file.WriteLine(aEmail + "," + aPassword + "," + aName + "," + aAddress + "," + aPhoneNo + "," + aCnic + "," + "ADMIN");
            file.Flush();
            file.Close();
        }
        //Store Bank Data In  file ......................
        static public void Store_Bank_Data_Into_File(string path,AdminBL a)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            StreamWriter file = new StreamWriter(path,true);
            file.Write(a.BankName + "," + a.BankEmail + "," + a.BankAdddress + "," + a.BankBranchID + "," + a.BankNo + "," + a.BankMoney);
            file.Flush();
            file.Close();
        }
        //Load Data From File For Bank............
        static public void load_bank_data()
        {
            AdminBL aL = new AdminBL();
            string path = "Bank_Data.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                AdminBL a = new AdminBL();
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] spiltRecord = record.Split(',');
                    a.BankName = spiltRecord[0];
                    a.BankEmail = spiltRecord[1];
                    a.BankAdddress = spiltRecord[2];
                    a.BankBranchID = spiltRecord[3];
                    a.BankNo = long.Parse(spiltRecord[4]);
                    a.BankMoney = long.Parse(spiltRecord[5]);
                    ListsDLUser.setlistOfBank(a);
                }
                fileVariable.Close();
            }
        }
        //File Load Data...........................................

        static public void loadAdminData()
        {
            User u1 = new User();
            string path = "SignIn_SignUp.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] spiltRecord = record.Split(',');
                    u1.Email = spiltRecord[0];
                    u1.Password = spiltRecord[1];
                    u1.Name = spiltRecord[2];
                    u1.Address = spiltRecord[3];
                    u1.PhoneNo = long.Parse(spiltRecord[4]);
                    u1.CNIC = long.Parse(spiltRecord[5]);
                    u1.Role = spiltRecord[6];
                    ListsDLUser.setList(u1);
                }
                fileVariable.Close();
            }

        }
        private static List<AdminBL> listOfBankData = new List<AdminBL>();
        public static List<AdminBL> getlistOfBank()
        {
            return listOfBankData;
        }
        public static void setlistOfBank(AdminBL A)
        {
            listOfBankData.Insert(0,A);
        }
        private static List<User> listofAdminandManager = new List<User>();
        public static List<User> getListOfAdminandManager()
        {
            return listofAdminandManager;
        }
        public static int getListCount()
        {
            return listofAdminandManager.Count();
        }
        public static void setList(User U)
        {
            listofAdminandManager.Add(U);
        }
        // Check Email Format......................................................
        public static bool checkEmail(string email)
        {
            char[] Mail = { '@', 'g', 'm', 'a', 'i', 'l', '.', 'c', 'o', 'm' };
            int lengthOfEmail = email.Length - 11;
            int countEmail = email.Length - 1;

            int i = 9;
            bool flag = false;
            while (countEmail != lengthOfEmail)
            {
                if (email[countEmail] == Mail[i])
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
                countEmail--;
                i--;
            }
            return flag;
        }
        //Check Bank Phone No  ...................................

        public static bool checkPhoneNoForBank(long aPhoneNo)
        {
            long pNo = aPhoneNo, b = 0;
            while (pNo != 0)
            {
                pNo = pNo / 10;
                b++;
                if (pNo == 0)
                {
                    if (b != 9)
                    {

                        return false;
                    }
                    else if (b == 9)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //Check Phone No  ...................................

        public static bool checkPhoneNo(long aPhoneNo)
        {
            long firstDigit;
            firstDigit = aPhoneNo / 100000000000;
            long pNo = aPhoneNo, b = 0;
            while (pNo != 0)
            {
                pNo = pNo / 10;
                b++;
                if (pNo == 0)
                {
                    if (b != 10 && firstDigit != 0)
                    {
                        return false;
                    }
                    else if (b == 10 && firstDigit == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //Check CNIC for Sign up ........................................

        public static bool checkCNIC(long aCNIC)
        {
            long firstDigit = aCNIC / 1000000000000;
            long cnic = aCNIC, b = 0;
            while (cnic != 0)
            {
                cnic = cnic / 10;
                b++;
                if (cnic == 0)
                {
                    if (b != 13 && firstDigit != 3)
                    {

                        return false;
                    }
                    else if (b == 13 && firstDigit == 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Finding Index function to reomve manager ............

        public static EmployeeBL indexOfUser(string eMail)
        {
            foreach (var user in EmployeeDL.getListofEmloyee())
            {
                if (eMail == user.Email)
                {
                    return user;
                }
            }
            return null;
        }
        //Finding Customer Specific...................................
        public static CustomerBL indexOfUser(string eMail, string extra)
        {
            foreach (var user in CustomerDL.getListofCustomer())
            {
                if (eMail == user.Email)
                {
                    return user;
                }
            }
            return null;
        }
        //
        
        public static string checkUser(string aEmail, string aPassword)
        {

            foreach (var a in ListsDLUser.getListOfAdminandManager())
            {
                if (a.Email == aEmail && a.Password == aPassword)
                {
                    return a.Role;
                }

            }
            foreach (var a in EmployeeDL.getListofEmloyee())
            {
                if (a.Email == aEmail && a.Password == aPassword)
                {
                    return a.Role;
                }
                EmployeeDL.specificIndexForEmployee++;
            }
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (a.Email == aEmail && a.Password == aPassword)
                {
                    return a.Role;
                }
                CustomerDL.specificIndexForCustomer++;
            }
            return " ";
        }
        
        //Check Phone No Already Existed.........................

        public static bool checkPhonNoAlreadyExisted(long aPhoneNo)
        {
            foreach (var a in EmployeeDL.getListofEmloyee())
            {
                if (aPhoneNo == a.PhoneNo)
                {
                    return false;
                }
            }
            foreach (var a in ListsDLUser.getListOfAdminandManager())
            {
                if (aPhoneNo == a.PhoneNo)
                {
                    return false;
                }
            }
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (aPhoneNo == a.PhoneNo)
                {
                    return false;
                }
            }
            return true;
        }
        //Check CNIC Already Existed..............................

        public static bool checkCNICAlreadyExisted(long aCNIC)
        {
            foreach (var a in EmployeeDL.getListofEmloyee())
            {
                if (aCNIC == a.CNIC)
                {
                    return false;
                }
            }
            foreach (var a in ListsDLUser.getListOfAdminandManager())
            {
                if (aCNIC == a.CNIC)
                {
                    return false;
                }
            }
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (aCNIC == a.CNIC)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
