using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.BL;
using BMS.DL;

namespace BMS.BL
{
    // Child Class Of User that is a admin...................................


    class AdminBL : User
    {
        public AdminBL(string aEmail, string aPassword, long aCNIC, string aAddress, long aPhoneNo, string aName) : base(aEmail, aPassword, aCNIC, aAddress, aPhoneNo, aName)
        {

        }
        public AdminBL()
        {

        }       
        private string bankName = "Null";
        private string bankEmail = "NULL";
        private string bankBranchId = "000";
        private long bankNo = 0000000000;
        private string bankAddress = "Null";
        private long bankMoney;

        public void setBankDetails(string aBankName, string aBankEmail, string aBankBranchId, string aBankAddress, long aBankNo,long aBankMoney)
        {
            BankName = aBankName;
            BankEmail = aBankEmail;
            BankBranchID = aBankBranchId;
            BankAdddress = aBankAddress;
            BankNo = aBankNo;
            BankMoney = aBankMoney;
        }
        public string BankName
        {
            get { return bankName; }
            set
            {
                bankName = value;
            }
        }
        public string BankEmail
        {
            get { return bankEmail; }
            set
            {
                bankEmail = value;
            }
        }
        public string BankBranchID
        {
            get { return bankBranchId; }
            set
            {
                bankBranchId = value;
            }
        }
        public long BankNo
        {
            get { return bankNo; }
            set
            {
                bankNo = value;
            }
        }
        public string BankAdddress
        {
            get { return bankAddress; }
            set
            {
                bankAddress = value;
            }
        }
        public long BankMoney
        {
            get { return bankMoney; }
            set
            {
                bankMoney = value;
            }
        }
    }
}
