using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    public class Contact
    {
        private static int incNum = 1;

        private int Code;
        public int ACode
        {
            set
            {
                this.Code = incNum;
            }
            get
            {
                return this.Code;
            }
        }
        
        private string FName;
        public string AnFName
        {
            get
            {
                return FName;
            }
            set
            {
                this.FName = AnFName;
            }
        }

        private string LName;
        public string AnLName
        {
            get
            {
                return LName;
            }
            set
            {
                this.LName = AnLName;
            }
        }

        private string MobPhone;
        public string AMobPhone
        {
            get
            {
                return MobPhone;
            }
            set
            {
                this.MobPhone = AMobPhone;
            }
        }

        public Contact(string fname,  string lname,  string mphone)
        {
            this.Code = incNum++;
            this.FName = fname;
            this.LName = lname;
            this.MobPhone = mphone;
        }

        public void PrintContact()
        {
            Console.WriteLine($"{this.Code} {FName} {LName} {MobPhone}");
        }
    }
}
