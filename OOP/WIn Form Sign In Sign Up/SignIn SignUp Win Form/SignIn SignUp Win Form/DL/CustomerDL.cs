using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using BMS.BL;


namespace BMS.DL
{
    class CustomerDL
    {
        static public long dailyAmount = 10000;
        static public long loanDail = 20000;
        static public int atmINdex;
        public static void deleteCustomerFromList(CustomerBL Temp)
        {
            for (int index = 0; index < listOfCustomer.Count; index++)
            {
                if (listOfCustomer[index].Name == Temp.Name && listOfCustomer[index].Password == Temp.Password && listOfCustomer[index].Email == Temp.Email)
                {
                    listOfCustomer.RemoveAt(index);
                }
            }
        }
        public static bool verifyATM(string atm,int pin)
        {
            if(getListofCustomer()[specificIndexForCustomer].AtmId == atm && getListofCustomer()[specificIndexForCustomer].AtmPassword == pin)
            {
                return true;
            }
            return false;
        }
        public static string verifyATM(string atm)
        {
            if (getListofCustomer()[specificIndexForCustomer].AtmId == atm)
            {
                return "same";
            }
            foreach(var a in getListofCustomer())
            {
                if(a.AtmId == atm)
                {
                    return "exist";
                }
            }
            return "false";
        }
        public static int indexForATM(string atm)
        {
            int i = 0;
            foreach (var a in getListofCustomer())
            {
                if (a.AtmId == atm)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static public void loadCustomersData()
        {
            
            string path = "Customer.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] spiltRecord = record.Split(',');
                    string Email = spiltRecord[0];
                    string Password = spiltRecord[1];
                    string Name = spiltRecord[2];
                    string Address = spiltRecord[3];
                    long PhoneNo = long.Parse(spiltRecord[4]);
                    long CNIC = long.Parse(spiltRecord[5]);
                    string Role = spiltRecord[6];
                    string AtmId = spiltRecord[7];
                    int AtmPassword = int.Parse(spiltRecord[8]);
                    string AccountType = spiltRecord[9];
                    long Amount = long.Parse(spiltRecord[10]);
                    CustomerBL u1 = new CustomerBL(Email, Password, CNIC, Address, PhoneNo, Name, "CUSTOMER");
                    u1.SetAtmForCustomer(AtmId,AtmPassword,AccountType,Amount);
                    setListOfCustomer(u1);
                }
                fileVariable.Close();
            }
        }
        public static void add_CustomersInTo_file2(string path, List<CustomerBL> cl)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            StreamWriter file = new StreamWriter(path, true);
            foreach (var c in cl)
            {
                file.WriteLine(c.Email + "," + c.Password + "," + c.Name + "," + c.Address + "," + c.PhoneNo + "," + c.CNIC + "," + "CUSTOMER" + "," + c.AtmId + "," + c.AtmPassword + "," + c.AccountType + "," + c.Amount);
            }
            file.Flush();
            file.Close();
        }
        public static void add_CustomersInTo_file(string path,CustomerBL c)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(c.Email + "," + c.Password + "," + c.Name + "," + c.Address + "," + c.PhoneNo + "," + c.CNIC + "," + "CUSTOMER" + "," + c.AtmId+ "," + c.AtmPassword + "," + c.AccountType + "," + c.Amount);
            file.Flush();
            file.Close();
        }
        //Check user for sign In......................
        public static int specificIndexForCustomer = 0;
        private static List<CustomerBL> listOfCustomer = new List<CustomerBL>();

        public static List<CustomerBL> getListofCustomer()
        {
            return listOfCustomer;
        }
        public static void setListOfCustomer(CustomerBL U)
        {
            listOfCustomer.Add(U);
        }

        //search......................
        private static List<CustomerBL> listOfCustomerForSearch = new List<CustomerBL>();
        public static List<CustomerBL> getlistOfCustomerForSearch()
        {
            return listOfCustomerForSearch;
        }
        public static void setlistOfECustomerForSearch(CustomerBL u)
        {
            listOfCustomerForSearch.Add(u);
        }
        static public bool customerToRemove(string email)
        {
            foreach (var a in getListofCustomer())
            {
                if (email == a.Email)
                {
                    getListofCustomer().Remove(a);
                    return true;
                }
            }
            return false;
        }
        static public void checkCustomer(string email)
        {
            foreach(var a in getListofCustomer())
            {
                if(email == a.Email)
                {
                    setlistOfECustomerForSearch(a);
                }
            }
        }
        //Update Name ..........................
        static public bool updateNameOfCustomer(string aName)
        {
            int i = 0;
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (specificIndexForCustomer == i)
                {
                    a.Name = aName;
                    return true;
                }
                i++;
            }
            return false;
        }
        static public void updateEmailOfCustomer(string aEmail)
        {
            int i = 0;
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (specificIndexForCustomer == i)
                {
                    a.Email = aEmail;
                }
                i++;
            }
        }
        static public void updateCNICForCustomer(long aCNIC)
        {
            int i = 0;
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (specificIndexForCustomer == i)
                {
                    a.CNIC = aCNIC;
                }
                i++;
            }
        }



        static public void updatePhnoNoForCustomer(long aPhoneNo)
        {
            int i = 0;
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (specificIndexForCustomer == i)
                {
                    a.PhoneNo = aPhoneNo;
                }
                i++;
            }
        }
        static public void updateAddressofCustomer(string aAddress)
        {
            int i = 0;
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (specificIndexForCustomer == i)
                {
                    a.Address = aAddress;
                }
                i++;
            }
        }
        static public void updatePasswordForCustomer(string aPassword)
        {
            int i = 0;
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (specificIndexForCustomer == i)
                {
                    a.Password = aPassword;
                }
                i++;
            }
        }
        //Update ATM ID...................................

        public static bool updateATMIDOfCustomer(string aATMID)
        {
            int i = 0;
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (specificIndexForCustomer == i)
                {
                    a.AtmId = aATMID;
                    return true;
                }
                i++;
            }
            return false;
        }

        //Update ATM Password...................................
        public static bool updateATMPasswordForCustomer(int aAtmPassword)
        {
            int i = 0;
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (specificIndexForCustomer == i)
                {
                    a.AtmPassword = aAtmPassword;
                    return true;
                }
                i++;
            }
            return false;
        }
        //Update Account Type...................................
        public static bool updateAccountOfCustomer(string aAccountType)
        {
            int i = 0;
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (specificIndexForCustomer == i)
                {
                    a.AccountType = aAccountType;
                    return true;
                }
                i++;
            }
            return false;
        }
        // Check ATM ID Format........................................
        public static bool atmIDFormat(string aATMID)
        {
            if (aATMID.Substring(4, 1) != "-" || aATMID.Substring(9, 1) != "-")
            {
                return false;
            }
            return true;
        }
        //Check Atm Id and Atm Password For Transactions....................................
        public static string atmTransactions(string aAtmId, long aAtmPassword)
        {
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (aAtmId == a.AtmId && aAtmPassword == a.AtmPassword)
                {
                    return a.AccountType;
                }
            }
            return null;
        }
        public static long atmTransactions(long aAtmPassword, string aAtmId)
        {
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (aAtmId == a.AtmId && aAtmPassword == a.AtmPassword)
                {
                    return a.Amount;
                }
            }
            return 0;
        }
        public static void atmTransactions(long aAtmPassword, string aAtmId, long aAmount1)
        {
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (aAtmId == a.AtmId && aAtmPassword == a.AtmPassword)
                {
                    a.Amount = a.Amount + aAmount1;
                }
            }
        }
        public static void atmTransactions(long aAmount1, long aAtmPassword, string aAtmId)
        {
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (aAtmId == a.AtmId && aAtmPassword == a.AtmPassword)
                {
                    a.Amount = a.Amount - aAmount1;
                }
            }
        }
        //Check User That Already Exists..............
        public static bool checkUserAlreadyExisted(string eemail)
        {
            foreach (var a in EmployeeDL.getListofEmloyee())
            {
                if (eemail == a.Email)
                {
                    return false;
                }
            }
            foreach (var a in ListsDLUser.getListOfAdminandManager())
            {
                if (eemail == a.Email)
                {
                    return false;
                }
            }
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (eemail == a.Email)
                {
                    return false;
                }
            }
            return true;
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
        //check IdAlready Existed....................................
        public static bool checkATMIdAlreadyExisted(string atmId)
        {
            foreach (var a in CustomerDL.getListofCustomer())
            {
                if (atmId == a.AtmId)
                {
                    return false;
                }
            }
            return true;
        }
        //Check Atm ID Password......................................
        public static bool atmPasswordLength(int aATMPassword)
        {
            int CATMpassword = aATMPassword;
            int p = 0;
            while (CATMpassword != 0)
            {
                CATMpassword = CATMpassword / 10;
                p++;
                if (CATMpassword == 0)
                {
                    if (p != 4)
                    {
                        return false;
                    }
                    else if (p == 4)
                    {
                        return true;
                    }
                }
            }
            return true;
        }
    }
}
