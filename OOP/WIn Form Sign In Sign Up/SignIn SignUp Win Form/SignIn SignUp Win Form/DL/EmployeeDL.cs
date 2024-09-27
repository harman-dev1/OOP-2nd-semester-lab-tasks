using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using BMS.BL;


namespace BMS.DL
{
    

    // List Of Employee .....................


    class EmployeeDL
    {
        
        public static void add_EmployeesInTo_file(string path, string aEmail, string aPassword, string aName, string aAddress, long aPhoneNo, long aCnic,string aEmployeeID,long employeeSalary,DateTime aInput)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(aEmail + "," + aPassword + "," + aName + "," + aAddress + "," + aPhoneNo + "," + aCnic + "," + "EMPLOYEE" + "," +aEmployeeID + "," + employeeSalary + "," + aInput);
            file.Flush();
            file.Close();
        }
        public static void add_EmployeesInTo_file2(string path,List<EmployeeBL> a1)
        {
            if(File.Exists(path))
            {
                File.Delete(path);
            }
            StreamWriter file = new StreamWriter(path, true);
            foreach(var a in a1)
            {
                file.WriteLine(a.Email + "," + a.Password + "," + a.Name + "," + a.Address + "," + a.PhoneNo + "," + a.CNIC + "," + "EMPLOYEE" + "," + a.EmployeeId + "," + a.Salary + "," + a.JoinDate);
            }
            file.Flush();
            file.Close();
        }
        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if(record[x] == ',')
                {
                    comma++;
                }
                else if(comma  == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static public void loadEmployeeData()
        {
            
            string path = "Employee.txt";
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
                    string EmployeeId = spiltRecord[7];
                    long Salary = long.Parse(spiltRecord[8]);
                    DateTime JoinDate = DateTime.Parse(spiltRecord[9]);
                    EmployeeBL a1 = new EmployeeBL(Email, Password, CNIC, Address, PhoneNo, Name, "EMPLOYEE");
                    a1.setExtraEmployeeInformation(EmployeeId, Salary, JoinDate);
                    setListOfEmployee(a1);
                }
                fileVariable.Close();
            }
            
        }
        public static bool checkEmployeeId(string aEmployeeId)
        {
            foreach (var a in EmployeeDL.getListofEmloyee())
            {
                if (a.EmployeeId == aEmployeeId)
                {
                    return false;
                }
            }
            return true;
        }


        // date of joining .............
        static public bool DOJ(string input)
        {
            DateTime date;
            if (DateTime.TryParseExact(input, "ddMMyy", null, System.Globalization.DateTimeStyles.None, out date))
            {
                int day = date.Day;
                int month = date.Month;
                int year = date.Year;

                //Console.WriteLine($"Day: {day}");
                //Console.WriteLine($"Month: {month}");
                //Console.WriteLine($"Year: {year}");

                return true;
            }
            else
            {
                return false;
            }

        }
     
        public static int specificIndexForEmployee = 0;
        private static List<EmployeeBL> listOfEmployee = new List<EmployeeBL>();

        public static List<EmployeeBL> getListofEmloyee()
        {
            return listOfEmployee;
        }
        public static void setListOfEmployee(EmployeeBL U)
        {
            listOfEmployee.Add(U);
        }
        //search......................
        private static List<EmployeeBL> listOfEmployeeForSearch  = new List<EmployeeBL>();
        public static List<EmployeeBL> getlistOfEmployeeForSearch()
        {
            return listOfEmployeeForSearch;
        }
        public static void setlistOfEmployeeForSearch(EmployeeBL u)
        {
            listOfEmployeeForSearch.Add(u);
        }
        static public bool employeeToRemove(string email)
        {
            foreach (var employee in getListofEmloyee())
            {
                if (email == employee.Email)
                {
                    EmployeeDL.getListofEmloyee().Remove(employee);
                    return true;
                }
            }
            return false;
        }
        static public EmployeeBL employee_remove(string email)
        {
            foreach (var a in getListofEmloyee())
            {
                if (email == a.Email)
                {
                    return a;
                }
            }
            return null;
        }
        static public void checkEmployee(string email)
        {
            foreach (var a in getListofEmloyee())
            {
                if (email == a.Email)
                {
                    setlistOfEmployeeForSearch(a);
                }
            }
            
        }
        static public void updateName(string aName)
        {

            int i = 0;
            foreach (var a in EmployeeDL.getListofEmloyee())
            {
                if (specificIndexForEmployee == i)
                {
                    a.Name = aName;

                }
                i++;
            }

        }

        static public void updateEmail(string aEmail)
        {
            int i = 0;
            foreach (var a in EmployeeDL.getListofEmloyee())
            {
                if (specificIndexForEmployee == i)
                {
                    a.Email = aEmail;
                }
                i++;
            }
        }
        static public void updateCNIC(long aCNIC)
        {
            int i = 0;
            foreach (var a in EmployeeDL.getListofEmloyee())
            {
                if (specificIndexForEmployee == i)
                {
                    a.CNIC = aCNIC;
                }
                i++;
            }
        }
        static public void updatePhnoNo(long aPhoneNo)
        {
            int i = 0;
            foreach (var a in EmployeeDL.getListofEmloyee())
            {
                if (specificIndexForEmployee == i)
                {
                    a.PhoneNo = aPhoneNo;
                }
                i++;
            }
        }
        static public void updateAddress(string aAddress)
        {
            int i = 0;
            foreach (var a in EmployeeDL.getListofEmloyee())
            {
                if (specificIndexForEmployee == i)
                {
                    a.Address = aAddress;
                }
                i++;
            }
        }

        static public void updatePassword(string aPassword)
        {
            int i = 0;
            foreach (var a in EmployeeDL.getListofEmloyee())
            {
                if (specificIndexForEmployee == i)
                {
                    a.Password = aPassword;
                }
                i++;
            }
        }

        public static long transactionReport()
        {
            long total = 0;
            foreach (var a in CustomerDL.getListofCustomer())
            {
                total = a.Amount + total;
            }
            return total;
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

        //Finding Customer Specific...................................

        public static CustomerBL indexOfUser(string eMail)
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
        public static void deleteEmployeeFromList(EmployeeBL Temp)
        {
            for (int index = 0; index < listOfEmployee.Count; index++)
            {
                if (listOfEmployee[index].Name == Temp.Name && listOfEmployee[index].Password == Temp.Password && listOfEmployee[index].CNIC == Temp.CNIC && listOfEmployee[index].CNIC == Temp.CNIC && listOfEmployee[index].Email == Temp.Email && listOfEmployee[index].JoinDate == Temp.JoinDate && listOfEmployee[index].Role == Temp.Role && listOfEmployee[index].Salary == Temp.Salary)
                {
                    listOfEmployee.RemoveAt(index);
                }
            }
        }
    }
}
