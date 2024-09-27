using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
        // Child Class Of Employee...................................

        class EmployeeBL : User
        {
        public EmployeeBL(string aEmail, string aPassword, long aCNIC, string aAddress, long aPhoneNo, string aName, string aRole)
        {
            email = aEmail;
            password = aPassword;
            cnic = aCNIC;
            address = aAddress;
            phoneNo = aPhoneNo;
            name = aName;
            role = aRole;
        }
        private string employeeId;
              private long salary;
              private DateTime joinDate;
              public string EmployeeId
              {
                 get { return employeeId; }
                 set
                 {
                       employeeId = value;
                 }
              }
        public long Salary
        {
            get { return salary; }
            set
            {
                salary = value;
            }
        }
        public DateTime JoinDate
        {
            get { return joinDate; }
            set
            {
                joinDate = value;
            }
        }
        public void setExtraEmployeeInformation(string aEmployeeId, long aSalary, DateTime aJoinDate)
        {
            EmployeeId = aEmployeeId;
            Salary = aSalary;
            JoinDate = aJoinDate;
        }
        public EmployeeBL()
        {

        }
        }
}
